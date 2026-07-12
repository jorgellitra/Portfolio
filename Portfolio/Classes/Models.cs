namespace Portfolio.Classes;

public enum VideoOrientation
{
    Landscape,
    Portrait
}

/// <summary>Section link shown in the home navigation bar.</summary>
public sealed record NavLink(string Label, string Url);

/// <summary>External link rendered with a Phosphor icon (e.g. "ph ph-github-logo").</summary>
public sealed record SocialLink(string Label, string Url, string Icon);

/// <summary>Global site identity: everything about the person, reused across pages.</summary>
public sealed class SiteIdentity
{
    public required string Name { get; init; }
    public required string JobTitle { get; init; }
    public required string Headline { get; init; }
    public required string Subheadline { get; init; }
    public required string PhotoPath { get; init; }
    public required string CvPath { get; init; }
    public required string CvLabel { get; init; }
    public required string Location { get; init; }
    public required int CopyrightYear { get; init; }
    public required string AboutTitle { get; init; }
    public required List<string> AboutParagraphs { get; init; }
    public required List<NavLink> NavLinks { get; init; }
    public required List<SocialLink> Socials { get; init; }
    public required List<SocialLink> ContactLinks { get; init; }
}

/// <summary>A project card on the home page.</summary>
public sealed class ProjectInfo
{
    public required string Title { get; init; }
    public required string Kicker { get; init; }
    public required string Meta { get; init; }
    public required string Description { get; init; }

    /// <summary>Video path relative to wwwroot (e.g. "videos/dhv.mp4#t=0.01"). Null = static image only.</summary>
    public string? VideoPath { get; init; }

    /// <summary>Poster / fallback image relative to wwwroot.</summary>
    public string? ImagePath { get; init; }

    public VideoOrientation Orientation { get; init; } = VideoOrientation.Landscape;

    /// <summary>Route of the case-study page (e.g. "puzzlechess"). Null = no page.</summary>
    public string? PageRoute { get; init; }

    /// <summary>Filter categories this project belongs to on the Work page (e.g. "Gameplay").</summary>
    public List<string> Tags { get; init; } = [];

    /// <summary>True to show this project in the featured grid on the Home page.</summary>
    public bool Featured { get; init; }

    public bool HasVideo => !string.IsNullOrEmpty(VideoPath);

    /// <summary>True when <see cref="VideoPath"/> is a YouTube link rather than a local file.
    /// These are embedded as an iframe (with the same hover-to-play behaviour) instead of a &lt;video&gt;.</summary>
    public bool IsYouTube => VideoPath is not null &&
                             (VideoPath.Contains("youtu.be/") || VideoPath.Contains("youtube.com/"));

    /// <summary>The video id parsed from a YouTube <see cref="VideoPath"/>, or null when it isn't one.</summary>
    public string? YouTubeId
    {
        get
        {
            if (!IsYouTube) return null;
            var marker = VideoPath!.Contains("youtu.be/") ? "youtu.be/" : "v=";
            var id = VideoPath[(VideoPath.IndexOf(marker, StringComparison.Ordinal) + marker.Length)..];
            var end = id.IndexOfAny(['?', '&', '/', '#']);
            return end >= 0 ? id[..end] : id;
        }
    }
}

/// <summary>Experience or education row.</summary>
public sealed class TimelineItem
{
    public required string Period { get; init; }
    public required string Role { get; init; }
    public required string Org { get; init; }
    public string? Description { get; init; }
}

/// <summary>Card in the "Technical highlights" grid of a project page.</summary>
public sealed class HighlightCard
{
    public required string Kicker { get; init; }
    public required string Title { get; init; }
    public required string What { get; init; }
    public required string Usage { get; init; }
}

/// <summary>Row in the "Next steps" list of a project page.</summary>
public sealed class NextStep
{
    public required string Icon { get; init; }
    public required string Title { get; init; }
    public required string Description { get; init; }
}

/// <summary>
/// Content of a project (case study) page, rendered by ProjectPageLayout.
/// Create one of these in PortfolioData for every new project page.
/// </summary>
public sealed class ProjectPageData
{
    public required string Title { get; init; }
    public required string Kicker { get; init; }
    public required string Summary { get; init; }
    public required string Role { get; init; }
    public required int TeamSize { get; init; }
    public required string Engine { get; init; }

    /// <summary>Store / play link shown as the nav action button.</summary>
    public string? StoreUrl { get; init; }
    public string StoreLabel { get; init; } = "Play it";

    /// <summary>Optional extra link row in the header facts (e.g. the itch.io page).</summary>
    public string? ProjectUrl { get; init; }
    public string? ProjectUrlLabel { get; init; }

    /// <summary>Portrait (mobile) gameplay video for the hero. Takes precedence over the image.</summary>
    public string? HeroVideoPath { get; init; }

    /// <summary>Landscape hero image (16:10) used when there is no portrait video.</summary>
    public string? HeroImagePath { get; init; }

    public string IntroductionTitle { get; init; } = "Introduction";
    public List<string> Introduction { get; init; } = [];

    public string HighlightsTitle { get; init; } = "Technical highlights";
    public string? HighlightsIntro { get; init; }

    /// <summary>Prefix of the usage line in each highlight card ("In PuzzleChess — ...").</summary>
    public string UsageLabel { get; init; } = "In this project";
    public List<HighlightCard> Highlights { get; init; } = [];

    public string NextStepsTitle { get; init; } = "Next Steps";
    public string? NextStepsIntro { get; init; }
    public List<NextStep> NextSteps { get; init; } = [];
}
