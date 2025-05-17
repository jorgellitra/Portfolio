namespace Portfolio.Classes;

public class PortfolioItem
{
    public int Id { get; set; }
    public string TitleEN { get; set; }
    public string DescriptionEN { get; set; }
    public string ImagePath { get; set; }
    public string Path { get; set; }
    public string? VideoPath { get; set; }
}

public static class PortfolioData
{
    public static List<string> TechnicalExperience = new List<string>()
    {
        "Unity",
        "C#",
        "Git",
        "Blazor",
        "MySQL",
        "SQL Server",
        "JQuery",
        "JavaScript",
        "Slack",
        "React",
        "API Development",
        "HTML",
        "PostgreSQL"
    };
    public static List<PortfolioItem> PersonalProjects => new List<PortfolioItem>
    {
        new PortfolioItem
        {
            Id= 1,
            TitleEN="Dimensional Hike",
            DescriptionEN= "Project I'm currently working on. It is a 2D and 3D game in which you will have to solve puzzles and go through different obstacles. My job is to develop all the programming of the game based on what I have already learned in the courses and my own personal training.",
            ImagePath= "dh",
            Path= "dh",
            VideoPath= "dhv"
        },
        new PortfolioItem {
            Id= 2,
            TitleEN="Building System",
            DescriptionEN= "Project in which I built some construction mechanics inspired by the famous survival game Valheim. I designed 3 types of structures; Wall, Floor and Ladder. Then, I added to each structure the relative positions I wanted it to have with respect to the others, taking into account its rotation. Finally, I added a particle system for when you destroy an object, some textures and buildings to improve the atmosphere.",
            ImagePath= "buildingi",
            Path= "buildingi",
            VideoPath= "buildingv"
        },
        new PortfolioItem {
            Id= 3,
            TitleEN="Pong Online",
            DescriptionEN= "This is my first project to learn how to manage LAN multiplayer in Unity. In it, I learned how to manage the tools that Unity offers you for online development ('Unity Netcode', 'Networking', 'Lobby', 'Relay'...). I wanted to recreate a simple game where I could offer a LAN experience having one of the users as Host.",
            ImagePath= "pongi",
            Path= "pongi",
            VideoPath= "pongv"
        },
        new PortfolioItem {
            Id= 4,
            TitleEN="Fall Guys Character Controller",
            DescriptionEN= "Project in which I recreated the main mechanics of Fall Guys. It was also the first time I animated a character and changed the modeling of an existing one. Mechanics= Double jump forward, grab a character, circular 3D camera, different types of traps...",
            ImagePath= "fguys",
            Path= "fguys",
            VideoPath= "fallguys"
        },
        new PortfolioItem {
            Id= 5,
            TitleEN="Procedural Map",
            DescriptionEN= "In this part of the training, I designed different rooms that were connected to each other on all four sides. Then I added a series of rules that make a different map is created for each level, being able to change the percentages of appearance of each type of room. All this helped me to learn the necessary basics and build a procedural map.",
            ImagePath= "procedural",
            Path= "procedural",
            VideoPath= "proceduralv"
        },
        new PortfolioItem {
            Id= 6,
            TitleEN="Unity Dialogue & Quests= Intermediate C# Game Coding",
            DescriptionEN= "Certified course where I learned how to make Scriptable Objects, create a window in Unity completely from 0 (in this case to make dialogs), program an inventory with drag and drop, create a dynamic saving system serializable and very easily extensible. ",
            ImagePath= "dialogue",
            Path= "dialogue",
            VideoPath= "dialoguev"
        },
        new PortfolioItem {
            Id= 7,
            TitleEN="Create an RPG Game in Unity",
            DescriptionEN= "In this course I learned how to create an entire RPG game. During the course, I used downloadable content modeling and this helped me to organize the project and program its functionalities. I learned how to design a level with terrain, how to take into account the lighting performance, the combat system of an RPG, etc.",
            ImagePath= "rpg",
            Path= "rpg",
            VideoPath= "rpgv"
        }
    };
    
    public static List<PortfolioItem> TokioSchool => new List<PortfolioItem>
    {
        new PortfolioItem {
            Id= 9,
            TitleEN="Activity 1",
            DescriptionEN= "As usual, the first project is to recreate the mythical video game Pong. In this practice, I was asked for the game to have power ups in case the ball hits any of them, the last player to touch the ball, is the one who will receive the power. It has a minimal AI for the second player to chase the height of the ball.",
            ImagePath= "pr1i",
            Path= "pr1i",
            VideoPath= "tokioschool/pr1v"
        },
        new PortfolioItem {
            Id= 10,
            TitleEN="Activity 2",
            DescriptionEN= "The aim of this practice was to acquire knowledge of the masks in Unity and an example of this is the way the moles appear. This is the Mole game, a classic of the fairs. The game consists of clicking as many moles as possible in a given time.",
            ImagePath= "pr2i",
            Path= "pr2i",
            VideoPath= "tokioschool/pr2v"
        },
        new PortfolioItem {
            Id= 11,
            TitleEN="Activity 3",
            DescriptionEN= "The brief for this practice was to make an Infinity Runner and I thought I would do it in 2D to learn about Tilemaps. As I wanted the character to have a bit more movement, it is the character that moves and as he moves forward more map is generated in front of him.",
            ImagePath= "pr3i",
            Path= "pr3i",
            VideoPath= "tokioschool/pr3v"
        },
        new PortfolioItem {
            Id= 12,
            TitleEN="Activity 4",
            DescriptionEN= "This project is based on the Clicker mechanic, every time you click on the enemy, it does damage and when you win, you get a reward that improves the damage, defence or health stats. I also added a way for the player to heal himself by clicking on his character.",
            ImagePath= "pr4i",
            Path= "pr4i",
            VideoPath= "tokioschool/pr4v"
        },
        new PortfolioItem {
            Id= 13,
            TitleEN="Activity 5",
            DescriptionEN= "At this point in the course, the physics of player movement was emphasised a bit more, trying to recreate the feeling of movement of the Mario Bros games; by pressing the jump button longer, you can jump higher, the acceleration movement of the character, etc.",
            ImagePath= "pr5i",
            Path= "pr5i",
            VideoPath= "tokioschool/pr5v"
        },
        new PortfolioItem {
            Id= 14,
            TitleEN="Activity 6",
            DescriptionEN= "For this practice, it consisted of playing the classic ship game, where waves of enemies and obstacles were arriving, with the peculiarity that power ups could appear and when they were hit by the player's bullets, the player would gain power. It is composed of 3 rounds and a local ranking of scores.",
            ImagePath= "pr6i",
            Path= "pr6i",
            VideoPath= "tokioschool/pr6v"
        },
        new PortfolioItem {
            Id= 15,
            TitleEN="Activity 7",
            DescriptionEN= "This project was a reconstruction of practice 5, as it asked us to make a metroidvania with a combat system and collectibles on the stage. I used a state machine for AI control and improved the player's movement from the previous practice and made use of the Cinemachine asset for camera control.",
            ImagePath= "pr7i",
            Path= "pr7i",
            VideoPath= "tokioschool/pr7v"
        },
        new PortfolioItem {
            Id= 16,
            TitleEN="Activity 8",
            DescriptionEN= "As you can see it was a simple practice to get familiar with the VR controls to simulate a museum. I added the DoTween asset for moving the player's position and levitating the stage spheres.",
            ImagePath= "pr8i",
            Path= "pr8i",
            VideoPath= "tokioschool/pr8v"
        },
        new PortfolioItem {
            Id= 17,
            TitleEN="Activity 9",
            DescriptionEN= "This practice was based on creating a First Person Shooter but with VR controls. I made use of Raycasts to detect the enemies and kill them, they would appear at certain points on the map and with the help of the NavMesh Agent they would advance towards the player.",
            ImagePath= "pr9i",
            Path= "pr9i",
            VideoPath= "tokioschool/pr9v"
        },
        new PortfolioItem {
            Id= 18,
            TitleEN="Activity 10",
            DescriptionEN= "Here, we were commissioned to make use of Vuforia's technology to detect Targets and create an application based on that technology, to recreate a system of molecules that interact with multiple targets and interact with each other.",
            ImagePath= "pr10i",
            Path= "pr10i",
            VideoPath= "tokioschool/pr10v"
        },
        new PortfolioItem {
            Id= 19,
            TitleEN="Activity 11",
            DescriptionEN= "Leaving the VR sector behind, this project consisted of making a First Person Shooter, making use of Unity's New Input System for the controls, I made a circuit shooter against the clock with different weapons, where you have to shoot all the targets. As a countermeasure, running or jumping uses up the player's stamina bar. Also, I added some design patterns like Singleton for the main classes and Object Pool for the weapon bullets.",
            ImagePath= "pr11i",
            Path= "pr11i",
            VideoPath= "tokioschool/pr11v"
        },
        new PortfolioItem {
            Id= 20,
            TitleEN="Activity 12",
            DescriptionEN= "In this last practice, we were assigned to make a simple mobile application to learn the basic functions of Unity in mobile controls. The project is a replica of Flappy Bird, where tapping makes the character rise up to dodge the pipes.",
            ImagePath= "pr12i",
            Path= "pr12i",
            VideoPath= "tokioschool/pr12v"
        },
        new PortfolioItem {
            Id= 21,
            TitleEN="Final Master",
            DescriptionEN= "Finally, this is my final master work, we were given 3 topics to work on and I decided to make a first person 3D game to increase my 3D knowledge as I hadn't done much during the course. The game consists of using the different weapons, which are unlocked as you go to the next level to complete the game in the shortest time possible and save your final score in an online database in Azure.\n " +
            "I have used all the tools learnt along the course and deepened some more, the most outstanding ones could be= the state machine for enemy AI, the use of New Input System for character control, postprocessing, scriptable objects for saving weapon data, cinemachine and design patterns like Singleton or structuring the code with SOLID Principles" +
            "For more details on the resources used in the project, see this document",
            ImagePath= "tfmi",
            Path= "tfmi",
            VideoPath= "https://www.youtube.com/embed/JbW8hk-s7dM?si=NrhBvubnTYvxES7V&amp;controls=0"
        }
    };
}
