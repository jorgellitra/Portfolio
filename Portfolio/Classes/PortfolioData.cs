namespace Portfolio.Classes;

public static class PortfolioData
{
    public const int HomeGridColumns = 3;

    public static readonly SiteIdentity Identity = new()
    {
        Name = "Jorge Quintana Llitrá",
        JobTitle = "Unity Gameplay Programmer",
        Headline = "Gameplay & systems programming, built on clean code.",
        Subheadline = "6+ years of professional software experience, currently shipping games at Rising Pixel. Creator of PuzzleChess, published on Google Play.",
        PhotoPath = "images/yo.jpg",
        CvPath = "files/CVEnglish.pdf",
        CvLabel = "Resume",
        Location = "Las Palmas de Gran Canaria, Spain",
        CopyrightYear = 2026,
        AboutTitle = "Hi, I'm Jorge",
        AboutParagraphs =
        [
            "Software and game developer with over 6 years of professional experience, currently at Rising Pixel in Las Palmas de Gran Canaria. My work focuses on gameplay and systems development in Unity, with backend/DevOps work on selected titles.",
            "I care about code that works efficiently and reads clearly — whether it's C#, Unity, or full-stack technologies.",
        ],
        NavLinks =
        [
            new("Projects", "#projects"),
            new("Experience", "#experience"),
            new("About", "#about"),
        ],
        Socials =
        [
            new("LinkedIn", "https://www.linkedin.com/in/jorge-quintana-llitr%C3%A1-00b66017b/", "ph ph-linkedin-logo"),
            new("GitHub", "https://github.com/jorgellitra", "ph ph-github-logo"),
            new("itch.io", "https://jorgellitra.itch.io/", "ph ph-game-controller"),
        ],
        ContactLinks =
        [
            new("LinkedIn", "https://www.linkedin.com/in/jorge-quintana-llitr%C3%A1-00b66017b/", "ph ph-linkedin-logo"),
            new("github.com/jorgellitra", "https://github.com/jorgellitra", "ph ph-github-logo"),
            new("jorgellitra.itch.io", "https://jorgellitra.itch.io/", "ph ph-game-controller"),
            new("CV (English, PDF)", "files/CVEnglish.pdf", "ph ph-file-pdf"),
        ],
    };

    public static readonly List<string> Skills =
    [
        "Unity", "C#", ".NET", "Git", "Blazor", "React", "JavaScript",
        "Supabase", "Firebase", "API Development", "MySQL", "SQL Server",
        "PostgreSQL", "OOP / OOD",
    ];

    /// <summary>
    /// Filter categories shown on the Work page. "All" is always first and
    /// matches everything. The rest match a project's <see cref="ProjectInfo.Tags"/>.
    /// </summary>
    public static readonly List<string> ProjectFilters =
    [
        "All", "Published", "Gameplay", "Systems", "Multiplayer", "Tokio School",
    ];

    /// <summary>
    /// Every project, in display order. The Home page shows the ones flagged
    /// <see cref="ProjectInfo.Featured"/>; the Work page shows them all.
    /// </summary>
    public static readonly List<ProjectInfo> AllProjects =
    [
        new()
        {
            Title = "PuzzleChess",
            Kicker = "Published · Mobile",
            Meta = "Solo · Unity",
            Description = "A puzzle game based on chess mechanics with 500 handcrafted levels, published on Google Play. Built to apply design patterns in a real shipped product.",
            VideoPath = "videos/puzzlechessv.mp4#t=0.01",
            Orientation = VideoOrientation.Portrait,
            PageRoute = "puzzlechess",
            Featured = true,
            Tags = ["Published"],
        },
        new()
        {
            Title = "Dimensional Hike",
            Kicker = "2D/3D Puzzle-Platformer",
            Meta = "Team of 2 · Unity",
            Description = "A hybrid 2D/3D puzzle-platformer built around dimensional shifts. Responsible for the entire gameplay programming.",
            VideoPath = "videos/dhv.mp4#t=0.01",
            ImagePath = "images/dh.png",
            Featured = true,
            Tags = ["Gameplay"],
        },
        new()
        {
            Title = "Building System",
            Kicker = "Systems Prototype",
            Meta = "Solo · Unity",
            Description = "A modular construction system inspired by Valheim — snapping for walls, floors and ladders with rotation-aware placement and destruction effects.",
            VideoPath = "videos/buildingv.mp4",
            ImagePath = "images/building.png",
            Featured = true,
            Tags = ["Systems"],
        },
        new()
        {
            Title = "Pong Online",
            Kicker = "Multiplayer · Netcode",
            Meta = "Solo · Unity",
            Description = "A networked Pong using Unity Netcode, Lobby and Relay — LAN play with one client acting as host and managing session flow.",
            VideoPath = "videos/pongv.mp4#t=0.01",
            ImagePath = "images/pong.png",
            Featured = true,
            Tags = ["Multiplayer", "Systems"],
        },
        new()
        {
            Title = "Fall Guys Character Controller",
            Kicker = "Gameplay Prototype",
            Meta = "Solo · Unity",
            Description = "A third-person controller replicating Fall Guys: double jump, grab interactions, trap handling and a dynamic 3D camera.",
            VideoPath = "videos/fallguys.mp4#t=0.01",
            ImagePath = "images/fguys.png",
            Featured = true,
            Tags = ["Gameplay"],
        },
        new()
        {
            Title = "Procedural Map",
            Kicker = "Procedural Generation",
            Meta = "Solo · Unity",
            Description = "Procedural level generation from modular rooms — spawn rules and probability weights produce a unique layout every run.",
            VideoPath = "videos/proceduralv.mp4#t=0.01",
            ImagePath = "images/procedural.png",
            Tags = ["Systems"],
        },

        // ── Tokio School — Gameplay Programming diploma coursework ──
        new()
        {
            Title = "Power-up Pong",
            Kicker = "Arcade Prototype",
            Meta = "Tokio School · Unity",
            Description = "An enhanced Pong with power-up mechanics: the last player to hit the ball gains the effect when it strikes a bonus. Includes basic AI that tracks the ball's Y position for single-player mode.",
            VideoPath = "videos/tokioschool/pr1v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr1i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "Whac-A-Mole",
            Kicker = "2D Prototype",
            Meta = "Tokio School · Unity",
            Description = "A classic Whac-A-Mole game created to practice Unity's masking system. Moles appear randomly and the player must hit as many as possible before time runs out.",
            VideoPath = "videos/tokioschool/pr2v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr2i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "Infinite Runner",
            Kicker = "2D · Tilemap",
            Meta = "Tokio School · Unity",
            Description = "A 2D infinite runner designed to explore Unity's Tilemap system. The character advances forward while the map is generated procedurally in front of them, simulating endless terrain.",
            VideoPath = "videos/tokioschool/pr3v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr3i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "Clicker Combat",
            Kicker = "Idle / Clicker",
            Meta = "Tokio School · Unity",
            Description = "A clicker-style game where players deal damage by clicking an enemy and earn rewards to improve their stats. Includes healing mechanics by interacting with the player's character.",
            VideoPath = "videos/tokioschool/pr4v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr4i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "Platformer Physics",
            Kicker = "2D Platformer",
            Meta = "Tokio School · Unity",
            Description = "A platformer prototype inspired by Mario Bros physics. Focused on replicating responsive jump mechanics, acceleration, and variable jump height based on button press duration.",
            VideoPath = "videos/tokioschool/pr5v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr5i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "Space Shooter",
            Kicker = "2D Shooter",
            Meta = "Tokio School · Unity",
            Description = "A 2D space shooter featuring enemy waves, obstacles, and power-ups activated by shooting them. Includes multiple rounds and a local high-score leaderboard.",
            VideoPath = "videos/tokioschool/pr6v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr6i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "Metroidvania",
            Kicker = "2D · AI",
            Meta = "Tokio School · Unity",
            Description = "A metroidvania prototype built from an earlier platformer. Introduced AI state machines, stage collectibles, a combat system, and used Cinemachine for dynamic camera control.",
            VideoPath = "videos/tokioschool/pr7v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr7i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "VR Museum",
            Kicker = "Virtual Reality",
            Meta = "Tokio School · Unity",
            Description = "A simple VR museum simulation to explore Unity's VR integration. Used DoTween for smooth player movement and visual effects like levitating orbs.",
            VideoPath = "videos/tokioschool/pr8v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr8i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "VR Shooter",
            Kicker = "VR · FPS",
            Meta = "Tokio School · Unity",
            Description = "A VR first-person shooter using raycasting for enemy detection. Enemies spawned and approached the player using Unity's NavMesh system for navigation.",
            VideoPath = "videos/tokioschool/pr9v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr9i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "AR Molecules",
            Kicker = "AR · Vuforia",
            Meta = "Tokio School · Unity",
            Description = "An AR application using Vuforia to detect multiple image targets and display interactive 3D molecules. Demonstrates multi-target interaction and basic augmented reality systems.",
            VideoPath = "videos/tokioschool/pr10v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr10i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "FPS Circuit",
            Kicker = "FPS Prototype",
            Meta = "Tokio School · Unity",
            Description = "A timed FPS circuit built with Unity's New Input System. Players complete the course by hitting all targets while managing stamina. Used Singleton and Object Pool design patterns for efficient architecture.",
            VideoPath = "videos/tokioschool/pr11v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr11i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "Flappy Clone",
            Kicker = "Mobile",
            Meta = "Tokio School · Unity",
            Description = "A mobile-friendly Flappy Bird clone created to practice Unity's mobile input handling. Tap mechanics were implemented for simple and responsive control.",
            VideoPath = "videos/tokioschool/pr12v.mp4#t=0.01",
            ImagePath = "images/tokioschool/pr12i.png",
            Tags = ["Tokio School"],
        },
        new()
        {
            Title = "Final Master's Project",
            Kicker = "Final Project · FPS",
            Meta = "Tokio School · Unity",
            Description = "A 3D first-person action game where players unlock weapons across levels and aim for the best time. Final scores are stored in an Azure-hosted database. Applied AI state machines, the New Input System, post-processing, ScriptableObjects for weapon data, Cinemachine and SOLID design principles.",
            VideoPath = "https://youtu.be/JbW8hk-s7dM",
            ImagePath = "images/tokioschool/tfmi.png",
            Featured = true,
            Tags = ["Tokio School"],
        },
    ];

    /// <summary>Featured projects shown on the Home page.</summary>
    public static IEnumerable<ProjectInfo> Projects => AllProjects.Where(p => p.Featured);

    public static readonly List<TimelineItem> Experience =
    [
        new()
        {
            Period = "2021 — Present",
            Role = "Game Developer",
            Org = "Rising Pixel SL",
            Description = "Full-time game development in Unity, plus backend/DevOps work on selected titles.",
        },
        new()
        {
            Period = "Previously",
            Role = "Software Developer",
            Org = "Symbyosys · GRUPO1844 · Minsait",
            Description = "Web development, object-oriented programming and scalable applications across several companies.",
        },
    ];

    public static readonly List<TimelineItem> Education =
    [
        new()
        {
            Period = "2023 — 2025",
            Role = "Higher Education Diploma — Gameplay Programming",
            Org = "Tokio School",
        },
        new()
        {
            Period = "2012 — 2018",
            Role = "Higher Education Diploma — Software Development",
            Org = "ULPGC (University of Las Palmas de Gran Canaria)",
        },
    ];

    public static readonly ProjectPageData PuzzleChessPage = new()
    {
        Title = "PuzzleChess",
        Kicker = "Published · Google Play",
        Summary = "A puzzle game based on chess mechanics, featuring 500 handcrafted levels. Each puzzle requires 1 or 2 precise moves to solve. Players earn free points by completing challenges or watching optional ads, redeemable for cosmetic skins.",
        Role = "Game Developer",
        TeamSize = 1,
        Engine = "Unity 6.1",
        StoreUrl = "https://jorgellitra.itch.io/puzzlechess",
        StoreLabel = "Play on itch.io",
        ProjectUrl = "https://jorgellitra.itch.io/puzzlechess",
        ProjectUrlLabel = "jorgellitra.itch.io/puzzlechess",
        HeroVideoPath = "videos/puzzlechessv.mp4#t=0.01",
        Introduction =
        [
            "After gaining valuable experience at Rising Pixel and deepening my knowledge through my academic studies, I felt it was the right moment to take on a personal challenge: develop and publish my own game. I wanted to consolidate everything I had learned — both technically and creatively — into a single, focused project.",
            "I deliberately chose a small-scope game that would allow me to experiment with and implement software architecture best practices, especially design patterns, without being constrained by the complexity or length of a large production. PuzzleChess became the perfect canvas to reinforce my skills in a real-world product, while also delivering a complete and polished mobile experience.",
        ],
        HighlightsTitle = "Design Patterns & Architecture",
        HighlightsIntro = "One of the core objectives of this project was to apply and test robust architecture principles in a real product. These are the main patterns implemented, each contributing to cleaner, scalable, more maintainable code.",
        UsageLabel = "In PuzzleChess",
        Highlights =
        [
            new()
            {
                Kicker = "Creational",
                Title = "Singleton",
                What = "Ensures a class has only one instance with a global access point — widely used in Unity for global services and persistent systems.",
                Usage = "Used for managers like IngameManager and ViewManager to ensure consistent access across scenes while avoiding duplication and lifecycle issues.",
            },
            new()
            {
                Kicker = "Behavioral",
                Title = "Strategy",
                What = "Enables selecting an algorithm at runtime — ideal when different behaviors are encapsulated in separate classes.",
                Usage = "Each chess piece (Rook, Knight, Bishop…) implements its own movement class derived from a shared interface, keeping logic modular and easy to extend.",
            },
            new()
            {
                Kicker = "Structural",
                Title = "Service Locator",
                What = "Lets objects access shared services without hard dependencies, improving decoupling and testability.",
                Usage = "A centralized ServicesManager provides access to input handling, the coin manager and audio configuration, reducing coupling between systems.",
            },
            new()
            {
                Kicker = "Optimization",
                Title = "Object Pooling",
                What = "Reuses frequently created objects instead of instantiating and destroying them — fewer GC allocations, better runtime performance.",
                Usage = "Unity's ObjectPool<T> drives the valid-move markers and the trail effects in the Knight Tour animation.",
            },
        ],
        NextStepsIntro = "With the core game released, a few key improvements will take PuzzleChess to the next level, both technically and in player experience.",
        NextSteps =
        [
            new()
            {
                Icon = "ph ph-arrow-counter-clockwise",
                Title = "Undo with the Command pattern",
                Description = "Store and reverse actions such as piece movements to enable undo — valuable for both strategy and accessibility.",
            },
            new()
            {
                Icon = "ph ph-translate",
                Title = "Localization for multiple languages",
                Description = "Support at least five languages using Unity's localization tools — a very useful topic across the industry.",
            },
            new()
            {
                Icon = "ph ph-chart-line-up",
                Title = "Gameplay analytics",
                Description = "Firebase or Unity Analytics to track engagement and puzzle difficulty — data to refine level design and improve retention.",
            },
        ],
    };
}
