# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this is

Personal portfolio for Jorge Quintana Llitrá (Unity Gameplay Programmer), built as a
**Blazor WebAssembly** static SPA (.NET 8). It is a content-only site — no backend, no
tests, no auth. It deploys to GitHub Pages at `https://jorgellitra.github.io/`.

The single project lives in `Portfolio/` (solution: `Portfolio.sln`).

## Commands

Run all from the repo root unless noted.

```bash
dotnet build                              # build
dotnet run --project Portfolio            # dev server (see launchSettings: http :5107, https :7079)
dotnet watch --project Portfolio          # dev server with hot reload
dotnet publish Portfolio -c Release       # production build (runs the custom GitHub Pages target — see below)
```

There is no test suite and no linter configured.

### Publishing to GitHub Pages

`dotnet publish -c Release` triggers a custom MSBuild target (`CustomizePublishOutput` in
`Portfolio/Portfolio.csproj`, runs `AfterTargets="Publish"`) that post-processes the output:

1. Flattens `wwwroot/**` up into the publish root (GitHub Pages serves from root, not `wwwroot`).
2. Rewrites `<base href="/" />` → `<base href="https://jorgellitra.github.io/" />` in `index.html`.
3. Writes an empty `.nojekyll` so GitHub Pages doesn't strip `_framework`.

If you change the deploy URL or the `<base href>` in `wwwroot/index.html`, update this target too.

Note a target-framework mismatch between tooling configs: `Portfolio.csproj` and
`FolderProfile.pubxml` target **net8.0**; `.run/Publish.run.xml` (Rider) targets net9.0.
The csproj is authoritative — prefer net8.0.

## Architecture

**Content is data, not markup.** Nearly all site copy (identity, projects, experience,
education, case-study pages, skills, filters) is centralized in
`Portfolio/Classes/PortfolioData.cs` as static readonly instances of the record/class
types defined in `Portfolio/Classes/Models.cs`. Razor pages and components are thin — they
iterate over `PortfolioData` collections and render. **To change site content, edit
`PortfolioData.cs`, not the `.razor` files.**

Key data flows:
- `PortfolioData.AllProjects` — every project. `Work.razor` (`/work`) shows all, filtered by
  `ProjectInfo.Tags` against `PortfolioData.ProjectFilters`. `PortfolioData.Projects` is the
  subset with `Featured = true`, shown on the Home grid.
- `PortfolioData.Identity` (`SiteIdentity`) — the person: name, headline, nav/social/contact
  links, CV path. Reused across all pages.
- Case-study pages are driven by `ProjectPageData`. `PuzzleChess.razor` (`/puzzlechess`) is
  just `<ProjectPageLayout Data="PortfolioData.PuzzleChessPage"/>`.

### Pages and routing
- `Home.razor` → `/`  |  `Work.razor` → `/work`  |  `PersonalProjects/PuzzleChess.razor` → `/puzzlechess`
- Routing is standard Blazor (`App.razor` + `MainLayout.razor`). `MainLayout` resets scroll on
  route change; **in-page `#anchor` links never reach the Blazor router** — they are handled by
  `wwwroot/js/site.js`, which smooth-scrolls them.

### Components (`Portfolio/Pages/Components/`)
Reusable, parameter-driven: `SiteNav` (two variants — home nav vs. back-link/action nav via
`BackHref`), `SiteFooter`, `ProjectCard`, `TimelineRow`, and `ProjectPageLayout` (the shared
case-study template, with an optional `ExtraSections` render fragment).

**Adding a new project case-study page:** (1) add a `ProjectPageData` entry to
`PortfolioData.cs`; (2) create a `.razor` page with `@page "/route"` that renders
`<ProjectPageLayout Data="PortfolioData.YourPage"/>`. See the comment at the top of
`ProjectPageLayout.razor`.

### Styling
Three global stylesheets, layered and loaded in `wwwroot/index.html` in this order:
1. `css/nocturne.css` — **the design system**: CSS-variable tokens (colors, ramps generated in
   OKLCH, spacing) and component classes. Source of truth for the look. Dark theme ("Nocturne").
2. `css/site.css` — page-layout classes on top of Nocturne. Breakpoints: **900px** (tablet),
   **640px** (mobile).
3. `css/app.css` — Blazor boilerplate (loading UI, error UI).

Prefer editing tokens/classes in `nocturne.css` over inline styles. Icons are
[Phosphor](https://phosphoricons.com/) loaded from a CDN; reference them as class strings
(e.g. `"ph ph-github-logo"`) in `PortfolioData.cs`.

### JS interop
`wwwroot/js/site.js` exposes `window.portfolio` (hover/tap-to-play project videos,
`scrollTop`) and handles in-page anchor scrolling. Media paths in `PortfolioData` are relative
to `wwwroot` (e.g. `"videos/dhv.mp4#t=0.01"`, the `#t=` sets the poster frame).
