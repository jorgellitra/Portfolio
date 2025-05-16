namespace Portfolio.Classes;

public class PortfolioItem
{
    public int Id { get; set; }
    public string TitleES { get; set; }
    public string TitleEN { get; set; }
    public string? SubtitleES { get; set; }
    public string? SubtitleEN { get; set; }
    public string DescriptionES { get; set; }
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
            TitleES="Dimensional Hike",
            TitleEN="Dimensional Hike",
            DescriptionES= "Proyecto en el que actualmente estoy trabajando. Se trata de un juego en 2D y 3D en el que tendrás que ir resolviendo puzzles y pasar entre distintos obstáculos. Mi trabajo consiste en desarrollar toda la programación del juego en base a lo que ya he aprendido en los cursos y mi propia formación personal.",
            DescriptionEN= "Project I'm currently working on. It is a 2D and 3D game in which you will have to solve puzzles and go through different obstacles. My job is to develop all the programming of the game based on what I have already learned in the courses and my own personal training.",
            ImagePath= "dh",
            Path= "dh",
            VideoPath= "dhv"
        },
        new PortfolioItem {
            Id= 2,
            TitleES="Building System",
            TitleEN="Building System",
            DescriptionES= "Proyecto en el cual construí unas mecánicas de construcción inspiradas en el famoso juego de supervivencia Valheim. Diseñé 3 tipos de estructuras; Muro, Suelo y Escalera. Luego, le añadí a cada estructura las posiciones relativas que quería que tuviera con respecto a las demás, teniendo en cuenta su rotación. Por último, le agregúe un sistema de particulas para cuando destruyes un objeto, unas texturas y edificios para mejorar la ambientación.",
            DescriptionEN= "Project in which I built some construction mechanics inspired by the famous survival game Valheim. I designed 3 types of structures; Wall, Floor and Ladder. Then, I added to each structure the relative positions I wanted it to have with respect to the others, taking into account its rotation. Finally, I added a particle system for when you destroy an object, some textures and buildings to improve the atmosphere.",
            ImagePath= "buildingi",
            Path= "buildingi",
            VideoPath= "buildingv"
        },
        new PortfolioItem {
            Id= 3,
            TitleES="Pong Online",
            TitleEN="Pong Online",
            DescriptionES= "Este es mi primer projecto para aprender a gestionar el multijugador en LAN en Unity. En él, aprendí a gestionar las herramientas que te ofrece Unity para el desarrollo del online ('Unity Netcode', 'Networking', 'Lobby', 'Relay'...). Quise recrear un juego sencillo donde pudiera ofrecer una experiencia en LAN teniendo a uno de los usuarios como Host.",
            DescriptionEN= "This is my first project to learn how to manage LAN multiplayer in Unity. In it, I learned how to manage the tools that Unity offers you for online development ('Unity Netcode', 'Networking', 'Lobby', 'Relay'...). I wanted to recreate a simple game where I could offer a LAN experience having one of the users as Host.",
            ImagePath= "pongi",
            Path= "pongi",
            VideoPath= "pongv"
        },
        new PortfolioItem {
            Id= 4,
            TitleES="Fall Guys Character Controller",
            TitleEN="Fall Guys Character Controller",
            DescriptionES= "Proyecto en el cual recreé las mecánicas principales de Fall Guys. También fue la primera vez que animé un personaje y cambié el modelado de uno ya existente. Mecánicas= Doble salto hacia adelante, agarrar a un personaje, cámara 3D circular, diferentes tipos de trampas...",
            DescriptionEN= "Project in which I recreated the main mechanics of Fall Guys. It was also the first time I animated a character and changed the modeling of an existing one. Mechanics= Double jump forward, grab a character, circular 3D camera, different types of traps...",
            ImagePath= "fguys",
            Path= "fguys",
            VideoPath= "fallguys"
        },
        new PortfolioItem {
            Id= 5,
            TitleES="Procedural Map",
            TitleEN="Procedural Map",
            DescriptionES= "En esta parte de la formación, he diseñado diferentes habitaciones que se conectaban entre sí por los cuatro lados. Luego añadí una serie de reglas que hacen que se cree un mapa diferente para cada nivel, pudiendo cambiar los porcentajes de aparición de cada tipo de habitación. Todo esto me sirvió para aprender las bases necesarias y construir así un mapa procedural.",
            DescriptionEN= "In this part of the training, I designed different rooms that were connected to each other on all four sides. Then I added a series of rules that make a different map is created for each level, being able to change the percentages of appearance of each type of room. All this helped me to learn the necessary basics and build a procedural map.",
            ImagePath= "procedural",
            Path= "procedural",
            VideoPath= "proceduralv"
        },
        new PortfolioItem {
            Id= 6,
            TitleES="Unity Dialogue & Quests= Intermediate C# Game Coding",
            TitleEN="Unity Dialogue & Quests= Intermediate C# Game Coding",
            DescriptionES= "Curso certificado donde aprendí a hacer Scriptables Objects, crear una ventana en Unity totalmente desde 0 (en este caso para hacer díalogos), programar un inventario con drag and drop, crear un sistema de guardado dinámico serializable y muy fácilmente extensible. ",
            DescriptionEN= "Certified course where I learned how to make Scriptable Objects, create a window in Unity completely from 0 (in this case to make dialogs), program an inventory with drag and drop, create a dynamic saving system serializable and very easily extensible. ",
            ImagePath= "dialogue",
            Path= "dialogue",
            VideoPath= "dialoguev"
        },
        new PortfolioItem {
            Id= 7,
            TitleES="Create an RPG Game in Unity",
            TitleEN="Create an RPG Game in Unity",
            DescriptionES= "En este curso aprendí a crear un juego entero de RPG. Durante el curso, he utilizado modelados de contenido descargable y ello me ayudó a organizar el proyecto y programar sus funcionalidades. Aprendía a diseñar un nivel con terreno, a tener en cuenta el rendimiento de la iluminación, al sistema de combate de un RPG, etc.",
            DescriptionEN= "In this course I learned how to create an entire RPG game. During the course, I used downloadable content modeling and this helped me to organize the project and program its functionalities. I learned how to design a level with terrain, how to take into account the lighting performance, the combat system of an RPG, etc.",
            ImagePath= "rpg",
            Path= "rpg",
            VideoPath= "rpgv"
        }
    };
    
    public static List<PortfolioItem> TokioSchool => new List<PortfolioItem>
    {
        new PortfolioItem {
            Id= 8,
            TitleES="Introducción",
            TitleEN="Introduction",
            SubtitleES="Introducción",
            SubtitleEN="Introduction",
            DescriptionES= "He decidido realizar este Master de programación de videojuegos en la escuela online Tokio School para afianzar los conocimientos básicos que he ido adquiriendo en mi carrera autodidacta, por eso a partir de este punto, voy a presentar las prácticas que se me han ido asignando a lo largo del curso.",
            DescriptionEN= "I have decided to take this Master's degree in video game programming at Tokio School online school to consolidate the basic knowledge I have been acquiring in my self-taught career, so from this point on, I will present the practices that have been assigned to me throughout the course.",
            ImagePath= "tokio",
            Path= "tokio",
            VideoPath= "tokio"
        },
        new PortfolioItem {
            Id= 9,
            TitleES="Práctica 1",
            TitleEN="Activity 1",
            SubtitleES="Práctica 1",
            SubtitleEN="Activity 1",
            DescriptionES= "Como viene siendo habitual, el primer proyecto es recrear el mítico videojuego Pong. En esta práctica, se me pidió que el juego tuviera power ups en caso de que la bola impacte en alguno, el último jugador en tocar la pelota, es el que recibirá el poder. Posee una IA mínima para que el segundo jugador persiga la altura de la pelota.",
            DescriptionEN= "As usual, the first project is to recreate the mythical video game Pong. In this practice, I was asked for the game to have power ups in case the ball hits any of them, the last player to touch the ball, is the one who will receive the power. It has a minimal AI for the second player to chase the height of the ball.",
            ImagePath= "pr1i",
            Path= "pr1i",
            VideoPath= "pr1v"
        },
        new PortfolioItem {
            Id= 10,
            TitleES="Práctica 2",
            TitleEN="Activity 2",
            SubtitleES="Práctica 2",
            SubtitleEN="Activity 2",
            DescriptionES= "El objetivo de esta práctica, era adquirir el conocimiento de las máscaras en Unity y un ejemplo de ello es en la manera que aparecen los topos. Este es el juego de Mole un clásico de las ferias. El juego consiste en clicar el mayor número de topos en un tiempo.",
            DescriptionEN= "The aim of this practice was to acquire knowledge of the masks in Unity and an example of this is the way the moles appear. This is the Mole game, a classic of the fairs. The game consists of clicking as many moles as possible in a given time.",
            ImagePath= "pr2i",
            Path= "pr2i",
            VideoPath= "pr2v"
        },
        new PortfolioItem {
            Id= 11,
            TitleES="Práctica 3",
            TitleEN="Activity 3",
            SubtitleES="Práctica 3",
            SubtitleEN="Activity 3",
            DescriptionES= "El enunciado de esta práctica era hacer un Infinity Runner y pensé en hacerlo en 2D para aprender sobre los Tilemaps. Como quería que el personaje tuviera un poco más de movimiento, es el personaje el que se mueve y a medida que avanza se va generando más mapa por delante de él.",
            DescriptionEN= "The brief for this practice was to make an Infinity Runner and I thought I would do it in 2D to learn about Tilemaps. As I wanted the character to have a bit more movement, it is the character that moves and as he moves forward more map is generated in front of him.",
            ImagePath= "pr3i",
            Path= "pr3i",
            VideoPath= "pr3v"
        },
        new PortfolioItem {
            Id= 12,
            TitleES="Práctica 4",
            TitleEN="Activity 4",
            SubtitleES="Práctica 4",
            SubtitleEN="Activity 4",
            DescriptionES= "Este proyecto se basa en la mecánica tipo Clicker, cada vez que clicas en el enemigo, le hace daño y al ganar, recibes una recompensa que mejora las estadisticas de daño defensa o vida. Tambíen le añadí una manera de que el jugador pueda curarse clicando en su personaje.",
            DescriptionEN= "This project is based on the Clicker mechanic, every time you click on the enemy, it does damage and when you win, you get a reward that improves the damage, defence or health stats. I also added a way for the player to heal himself by clicking on his character.",
            ImagePath= "pr4i",
            Path= "pr4i",
            VideoPath= "pr4v"
        },
        new PortfolioItem {
            Id= 13,
            TitleES="Práctica 5",
            TitleEN="Activity 5",
            SubtitleES="Práctica 5",
            SubtitleEN="Activity 5",
            DescriptionES= "En este punto del curso se nos insistió un poco más en las físicas del movimiento del jugador, intentando recrear la sensación de movimiento de los juegos de Mario Bros; al pulsar más tiempo el botón de saltar puedes saltar más alto, el movimiento de aceleración del personaje, etc.",
            DescriptionEN= "At this point in the course, the physics of player movement was emphasised a bit more, trying to recreate the feeling of movement of the Mario Bros games; by pressing the jump button longer, you can jump higher, the acceleration movement of the character, etc.",
            ImagePath= "pr5i",
            Path= "pr5i",
            VideoPath= "pr5v"
        },
        new PortfolioItem {
            Id= 14,
            TitleES="Práctica 6",
            TitleEN="Activity 6",
            SubtitleES="Práctica 6",
            SubtitleEN="Activity 6",
            DescriptionES= "Para esta práctica, consistía en hacer el clásico juego de naves, donde iban llegando oleadas de enemigos y obstaculos, con la peculiaridad que podían aparecer power ups que al se impactados por las balas del jugador, este se ganada el poder. Está compuesto de 3 rondas y un ranking de puntuaciones local.",
            DescriptionEN= "For this practice, it consisted of playing the classic ship game, where waves of enemies and obstacles were arriving, with the peculiarity that power ups could appear and when they were hit by the player's bullets, the player would gain power. It is composed of 3 rounds and a local ranking of scores.",
            ImagePath= "pr6i",
            Path= "pr6i",
            VideoPath= "pr6v"
        },
        new PortfolioItem {
            Id= 15,
            TitleES="Práctica 7",
            TitleEN="Activity 7",
            SubtitleES="Práctica 7",
            SubtitleEN="Activity 7",
            DescriptionES= "Este proyecto fue una reconstrucción de la práctica 5, ya que nos pedía hacer un metroidvania con sistema de combate y objetos coleccionables en el escenario. Utilicé una máquina de estados para el control de la IA y perfeccioné el movimiento del jugador con respecto a la práctica anterior e hice uso del asset Cinemachine para el control de la cámara.",
            DescriptionEN= "This project was a reconstruction of practice 5, as it asked us to make a metroidvania with a combat system and collectibles on the stage. I used a state machine for AI control and improved the player's movement from the previous practice and made use of the Cinemachine asset for camera control.",
            ImagePath= "pr7i",
            Path= "pr7i",
            VideoPath= "pr7v"
        },
        new PortfolioItem {
            Id= 16,
            TitleES="Práctica 8",
            TitleEN="Activity 8",
            SubtitleES="Práctica 8",
            SubtitleEN="Activity 8",
            DescriptionES= "Como se puede observar consistía en una práctica sencilla para familiarizarse con los controles de VR para simular un museo. Le añadí el asset DoTween para el traslado de la posición del jugador y la levitación de las esferas del escenario.",
            DescriptionEN= "As you can see it was a simple practice to get familiar with the VR controls to simulate a museum. I added the DoTween asset for moving the player's position and levitating the stage spheres.",
            ImagePath= "pr8i",
            Path= "pr8i",
            VideoPath= "pr8v"
        },
        new PortfolioItem {
            Id= 17,
            TitleES="Práctica 9",
            TitleEN="Activity 9",
            SubtitleES="Práctica 9",
            SubtitleEN="Activity 9",
            DescriptionES= "Esta práctica se basada en crear un First Person Shooter pero con los controles de VR. Hice uso de Raycasts para detectar a los enemigos y matarlos, iban apareciendo en ciertos puntos del mapa y con la ayuda del NavMesh Agent irían avanzando hacía el jugador.",
            DescriptionEN= "This practice was based on creating a First Person Shooter but with VR controls. I made use of Raycasts to detect the enemies and kill them, they would appear at certain points on the map and with the help of the NavMesh Agent they would advance towards the player.",
            ImagePath= "pr9i",
            Path= "pr9i",
            VideoPath= "pr9v"
        },
        new PortfolioItem {
            Id= 18,
            TitleES="Práctica 10",
            TitleEN="Activity 10",
            SubtitleES="Práctica 10",
            SubtitleEN="Activity 10",
            DescriptionES= "Aquí, nos encargaron hacer uso de la tecnología de Vuforia para detectar Targets y crear una aplicación en base a esa tecnología, para recrear un sistema de moléculas y que al interactuar con los múltiples targets interaccionaran entre ellos.",
            DescriptionEN= "Here, we were commissioned to make use of Vuforia's technology to detect Targets and create an application based on that technology, to recreate a system of molecules that interact with multiple targets and interact with each other.",
            ImagePath= "pr10i",
            Path= "pr10i",
            VideoPath= "pr10v"
        },
        new PortfolioItem {
            Id= 19,
            TitleES="Práctica 11",
            TitleEN="Activity 11",
            SubtitleES="Práctica 11",
            SubtitleEN="Activity 11",
            DescriptionES= "Dejando atrás el sector VR, este proyecto consistía es hacer un First Person Shooter, haciendo uso del New Input System de Unity para los controles, hice un shooter a modo de circuito a contrarreloj con diferentes armas, donde tienes que disparas a todos los objetivos. Como contramedida, al correr o saltar se gasta la barra de estamina del jugador.\n También, añadí algunos patrones de diseño como Singleton para las clases principales y Object Pool para las balas de las armas.",
            DescriptionEN= "Leaving the VR sector behind, this project consisted of making a First Person Shooter, making use of Unity's New Input System for the controls, I made a circuit shooter against the clock with different weapons, where you have to shoot all the targets. As a countermeasure, running or jumping uses up the player's stamina bar. Also, I added some design patterns like Singleton for the main classes and Object Pool for the weapon bullets.",
            ImagePath= "pr11i",
            Path= "pr11i",
            VideoPath= "pr11v"
        },
        new PortfolioItem {
            Id= 20,
            TitleES="Práctica 12",
            TitleEN="Activity 12",
            SubtitleES="Práctica 12",
            SubtitleEN="Activity 12",
            DescriptionES= "En esta última práctica, se nos asignó hacer una aplicación sencilla para móvil y así poder conocer las funciones básicas de Unity en los controles de los móviles. El proyecto es un réplica del Flappy Bird, donde al pulsar consigues que el personaje se eleve para esquibar las tuberías.",
            DescriptionEN= "In this last practice, we were assigned to make a simple mobile application to learn the basic functions of Unity in mobile controls. The project is a replica of Flappy Bird, where tapping makes the character rise up to dodge the pipes.",
            ImagePath= "pr12i",
            Path= "pr12i",
            VideoPath= "pr12v"
        },
        new PortfolioItem {
            Id= 21,
            TitleES="Trabajo final de Master",
            TitleEN="Final Master",
            SubtitleES="Trabajo final de Master",
            SubtitleEN="Final Master's project",
            DescriptionES= "Por último, este es mi trabajo final de master, nos dieron 3 temas sobre los que poder trabajar y decidí hacer un juego en 3D en primera persona para aumentar mis conocimientos en 3D ya que no lo había hecho mucho durante el curso.\n El juego consiste en hacer uso de las diferentes armas, que se van desbloqueando a medida que pasas al siguiente nivel para completar el juego en el menor tiempo posible y guardar tu puntuación final en una base de datos online en Azure.\n " +
            "He usado todas las herramientas aprendidas a lo largo del curso y profundizado en algunas más, las más destacadas podrían ser= la máquina de estados para la IA de los enemigos, el uso de New Input System para el control del personaje, el postprocessing, scriptable objects para la guardar los datos de las armas, cinemachine y patrones de diseño como Singleton o estructurando el código con los Principios SOLID." +
            "Para mayor detalle de los recursos usados en el proyecto, se pueden ver en este documento= ",
            DescriptionEN= "Finally, this is my final master work, we were given 3 topics to work on and I decided to make a first person 3D game to increase my 3D knowledge as I hadn't done much during the course. The game consists of using the different weapons, which are unlocked as you go to the next level to complete the game in the shortest time possible and save your final score in an online database in Azure.\n " +
            "I have used all the tools learnt along the course and deepened some more, the most outstanding ones could be= the state machine for enemy AI, the use of New Input System for character control, postprocessing, scriptable objects for saving weapon data, cinemachine and design patterns like Singleton or structuring the code with SOLID Principles" +
            "For more details on the resources used in the project, see this document= ",
            ImagePath= "tfmi",
            Path= "tfmi",
            VideoPath= "https=//youtu.be/JbW8hk-s7dM"
        }
    };
}
