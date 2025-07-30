namespace Portfolio.Classes;

public class PortfolioItem
{
    public string TitleEN { get; set; }
    public string DescriptionEN { get; set; }
    public string Path { get; set; }
    public string? VideoPath { get; set; }
    public int PeopleInvolve { get; set; } = 1;
    public bool HasOwnPage { get; set; } = false;
}

public class PortfolioPage
{
    public string Title { get; set; }
    public string About { get; set; }
    public string Role { get; set; }
    public int TeamSize { get; set; }
    public string Engine { get; set; }
    public string Introduction { get; set; }
    public string StoreUrl { get; set; }
}

public static class PortfolioData
{
    public static List<string> TechnicalExperience =
    [
        "Unity",
        "C#",
        ".NET",
        "Git",
        "Blazor",
        "Supabase",
        "Firebase",
        "API Development",
        "MySQL",
        "SQL Server",
        "JQuery",
        "JavaScript",
        "Slack",
        "OOP",
        "OOD",
        "React",
        "HTML",
        "PostgreSQL"
    ];

    public static List<PortfolioItem> PersonalProjects =>
    [
        new PortfolioItem {
            TitleEN = "PuzzleChess",
            DescriptionEN = "My first mobile game published on Play Store. A puzzle game based on chess mechanics featuring 500 handcrafted levels. Each puzzle requires 1 or 2 precise moves to solve. Players earn free points by completing challenges or watching optional ads, which can be redeemed to unlock cosmetic skins.",
            Path = "puzzlechess",
            VideoPath = "puzzlechessv",
            HasOwnPage = true
        },
        new PortfolioItem
        {
            TitleEN = "Dimensional Hike",
            DescriptionEN = "A hybrid 2D/3D puzzle-platformer where players solve challenges and navigate obstacles across dimensional shifts. I was responsible for the entire gameplay programming, applying knowledge from structured coursework and self-driven learning.",
            Path = "dh",
            VideoPath = "dhv",
            PeopleInvolve = 2
        },
        new PortfolioItem {
            TitleEN = "Building System",
            DescriptionEN = "A modular construction system inspired by Valheim. I implemented snapping mechanics for wall, floor, and ladder elements with rotation-aware placement. Additional features included particle effects on destruction and environmental enhancements for visual feedback.",
            Path = "buildingi",
            VideoPath = "buildingv"
        },
        new PortfolioItem {
            TitleEN = "Pong Online",
            DescriptionEN = "My first networked multiplayer project using Unity Netcode tools such as Lobby and Relay. I recreated a classic Pong experience with LAN functionality, allowing one user to act as host and manage session flow.",
            Path = "pongi",
            VideoPath = "pongv"
        },
        new PortfolioItem {
            TitleEN = "Fall Guys Character Controller",
            DescriptionEN = "A mechanics prototype replicating core features from Fall Guys. I developed a third-person character controller with double jump, grab interactions, trap handling, and a dynamic 3D camera. This project also introduced me to character animation and model modification.",
            Path = "fguys",
            VideoPath = "fallguys"
        },
        new PortfolioItem {
            TitleEN = "Procedural Map",
            DescriptionEN = "Designed a procedural level generation system using modular room components. Each level creates a unique layout by applying spawn rules and probability weights for room types, building the foundation for scalable procedural content.",
            Path = "procedural",
            VideoPath = "proceduralv"
        },
        new PortfolioItem {
            TitleEN = "Dialogue & Quests: Intermediate C# Game Coding",
            DescriptionEN = "Certified course focused on intermediate C# systems for games. I implemented ScriptableObject-based dialogues, built a custom Unity editor window, created a drag-and-drop inventory UI, and developed a modular save system using serialization.",
            Path = "dialogue",
            VideoPath = "dialoguev"
        },
        new PortfolioItem {
            TitleEN = "Create an RPG Game in Unity",
            DescriptionEN = "Completed a full-scale RPG development course. I learned environment design with Unity terrain tools, optimized lighting for performance, and implemented core RPG systems including inventory, combat, and character progression.",
            Path = "rpg",
            VideoPath = "rpgv"
        }
    ];
    
    public static List<PortfolioItem> TokioSchool => new List<PortfolioItem>
    {
        new PortfolioItem {
            TitleEN = "Project 1",
            DescriptionEN = "An enhanced Pong game with power-up mechanics. The last player to hit the ball gains the effect when it strikes a bonus. Includes basic AI that tracks the ball’s Y position for single-player mode.",
            Path = "pr1i",
            VideoPath = "tokioschool/pr1v"
        },
        new PortfolioItem {
            TitleEN = "Project 2",
            DescriptionEN = "A classic Whac-A-Mole game created to practice Unity’s masking system. Moles appear randomly and the player must hit as many as possible before time runs out.",
            Path = "pr2i",
            VideoPath = "tokioschool/pr2v"
        },
        new PortfolioItem {
            TitleEN = "Project 3",
            DescriptionEN = "A 2D infinite runner designed to explore Unity's Tilemap system. The character advances forward while the map is generated procedurally in front of them, simulating endless terrain.",
            Path = "pr3i",
            VideoPath = "tokioschool/pr3v"
        },
        new PortfolioItem {
            TitleEN = "Project 4",
            DescriptionEN = "A clicker-style game where players deal damage by clicking an enemy and earn rewards to improve their stats. Includes healing mechanics by interacting with the player’s character.",
            Path = "pr4i",
            VideoPath = "tokioschool/pr4v"
        },
        new PortfolioItem {
            TitleEN = "Project 5",
            DescriptionEN = "Platformer prototype inspired by Mario Bros physics. Focused on replicating responsive jump mechanics, acceleration, and variable jump height based on button press duration.",
            Path = "pr5i",
            VideoPath = "tokioschool/pr5v"
        },
        new PortfolioItem {
            TitleEN = "Project 6",
            DescriptionEN = "A 2D space shooter featuring enemy waves, obstacles, and power-ups activated by shooting them. Includes multiple rounds and a local high-score leaderboard.",
            Path = "pr6i",
            VideoPath = "tokioschool/pr6v"
        },
        new PortfolioItem {
            TitleEN = "Project 7",
            DescriptionEN = "A metroidvania prototype built from an earlier platformer. Introduced AI state machines, stage collectibles, combat system, and used Cinemachine for dynamic camera control.",
            Path = "pr7i",
            VideoPath = "tokioschool/pr7v"
        },
        new PortfolioItem {
            TitleEN = "Project 8",
            DescriptionEN = "A simple VR museum simulation to explore Unity’s VR integration. Used DoTween for smooth player movement and visual effects like levitating orbs.",
            Path = "pr8i",
            VideoPath = "tokioschool/pr8v"
        },
        new PortfolioItem {
            TitleEN = "Project 9",
            DescriptionEN = "A VR first-person shooter using raycasting for enemy detection. Enemies spawned and approached the player using Unity’s NavMesh system for navigation.",
            Path = "pr9i",
            VideoPath = "tokioschool/pr9v"
        },
        new PortfolioItem {
            TitleEN = "Project 10",
            DescriptionEN = "An AR application using Vuforia to detect multiple image targets and display interactive 3D molecules. Demonstrates multi-target interaction and basic augmented reality systems.",
            Path = "pr10i",
            VideoPath = "tokioschool/pr10v"
        },
        new PortfolioItem {
            TitleEN = "Project 11",
            DescriptionEN = "A timed FPS circuit built with Unity’s New Input System. Players complete the course by hitting all targets while managing stamina. Used Singleton and Object Pool design patterns for efficient architecture.",
            Path = "pr11i",
            VideoPath = "tokioschool/pr11v"
        },
        new PortfolioItem {
            TitleEN = "Project 12",
            DescriptionEN = "A mobile-friendly Flappy Bird clone created to practice Unity’s mobile input handling. Tap mechanics were implemented for simple and responsive control.",
            Path = "pr12i",
            VideoPath = "tokioschool/pr12v"
        },
        new PortfolioItem {
            TitleEN = "Final Master's Project",
            DescriptionEN = "A 3D first-person action game where players unlock weapons across levels and aim for the best time. Data such as final scores is stored in an Azure-hosted database. Applied a wide range of concepts from the course: state machines for AI, Unity’s New Input System, post-processing, ScriptableObjects for weapon data, Cinemachine for camera control, and SOLID design principles. For more technical details, refer to the project documentation.",
            Path = "tfmi",
            VideoPath = "https://www.youtube.com/embed/JbW8hk-s7dM?si=NrhBvubnTYvxES7V&amp;controls=0"
        }
    };

    public static PortfolioPage PuzzleChess = new PortfolioPage
    {
        Title = "PuzzleChess",
        About = "PuzzleChess is my first mobile game published on Play Store. It is a puzzle game based on chess mechanics, featuring 500 handcrafted levels. Each puzzle requires 1 or 2 precise moves to solve. Players earn free points by completing challenges or watching optional ads, which can be redeemed to unlock cosmetic skins.",
        Role = "Game Developer",
        TeamSize = 1,
        Engine = "Unity",
        Introduction = "After gaining valuable experience at Rising Pixel and deepening my knowledge through my academic studies, I felt it was the right moment to take on a personal challenge: develop and publish my own game. I wanted to consolidate everything I had learned—both technically and creatively—into a single, focused project.\r\n\r\nI deliberately chose a small-scope game that would allow me to experiment with and implement software architecture best practices, especially design patterns, without being constrained by the complexity or length of a large production. PuzzleChess became the perfect canvas to reinforce my skills in a real-world product, while also delivering a complete and polished mobile experience.",
        StoreUrl = "https://play.google.com/store/apps/details?id=com.puzzlechess",
    };
}
