using System.Diagnostics;

/* Date: July 27 2022
Name: Cody Howell
Lab: Final Project */

//Methods
static void TryMove(int proposedTop, int proposedLeft, string[] screen){ //reusing code from Lab 7
    if (proposedTop < screen.Length && proposedTop > 0 && screen[proposedTop][proposedLeft] != '^' && screen[proposedTop][proposedLeft] != '#')
        {Console.CursorTop = proposedTop;}
    if (proposedLeft < screen[0].Length && proposedLeft > 0 && screen[proposedTop][proposedLeft] != '^' && screen[proposedTop][proposedLeft] != '#')
        {Console.CursorLeft = proposedLeft;}
}

//Initialization
Random rand = new Random();
int map = 0; //Number representing which map should be up.
bool checkPointReached = false;
bool inMaze = false;
bool inBoss = false;
bool winning = false;
bool dead = false;
bool oppDead = false;
int health = 100;
int enemyHealth = rand.Next(20,50);
int attack = rand.Next(5,15);
Stopwatch stopwatch = new Stopwatch();


Console.Clear();

Console.WriteLine(@"Hello, and welcome to the game. You are a [sprite not found], wandering around a map.
You'll have to defeat random enemies, solve a maze, and beat the boss at the end. Good luck!
Press any key to begin.");
Console.ReadKey(true);
stopwatch.Start();

do {
    string[] screen = new string[20];
    string[] mapPath = new string[7] {"Map.txt" , "Maze 1.txt" , "Maze 2.txt" , "Maze 3.txt" , "Maze 4.txt" , "Boss.txt" , "Random Encounters.txt"};
    screen = File.ReadAllLines(mapPath[map]);
    Console.Clear();
    foreach (string line in screen){
        Console.WriteLine(line);
    }
    
    if (checkPointReached == false){Console.CursorTop = 3; Console.CursorLeft = 4;}
    else if (map == 5){Console.CursorTop = 16; Console.CursorLeft = 24;}
    else if (map > 0 && map < 5){Console.CursorTop = 1; Console.CursorLeft = 1;}
    else {Console.CursorTop = 8; Console.CursorLeft = 52;} // Placement for checkpoints

    while (map != 6 && winning == false){
        var dir = Console.ReadKey(true).Key; 
        switch (dir){ //Second stolen thing, going to clean it with a Switch function, hopefully.
            case ConsoleKey.UpArrow:
                TryMove(Console.CursorTop-1, Console.CursorLeft, screen);
                break;
            case ConsoleKey.DownArrow:
                TryMove(Console.CursorTop+1, Console.CursorLeft, screen);
                break;
            case ConsoleKey.LeftArrow:
                TryMove(Console.CursorTop, Console.CursorLeft-1, screen);
                break;
            case ConsoleKey.RightArrow:
                TryMove(Console.CursorTop, Console.CursorLeft+1, screen);
                break;
            //You don't get an escape key. :/
        }
        if (screen[Console.CursorTop][Console.CursorLeft] == '!'){ 
            Console.Clear();
            Console.WriteLine("You died! Don't touch those => !");
            Console.WriteLine("Press a key to respawn.");
            Console.ReadKey(true);
            map = 0;
            inBoss = false;
            break;
        }
        if (screen[Console.CursorTop][Console.CursorLeft] == '$' && inBoss == true){
            winning = true;
            stopwatch.Stop();
            break;
        }
        if (screen[Console.CursorTop][Console.CursorLeft] == '*' && inMaze == true){
            map = 0;
            inMaze = false;
            break;
        }
        if (screen[Console.CursorTop][Console.CursorLeft] == '$' && checkPointReached == true){
            map = 5;
            inBoss = true;
            break;
        }
        if (screen[Console.CursorTop][Console.CursorLeft] == '*'){ 
            inMaze = true;
            checkPointReached = true;
            map = rand.Next(1,4); 
            break;
        }
    }

    if (map == 6){
        do {

        } while (health != 0 && enemyHealth != 0);
        //break stuff here.
    }
} while (winning == false);

Console.Clear();
double seconds = stopwatch.ElapsedMilliseconds / 1000.0;
Console.WriteLine($"Congrats! You won. It only took you {Math.Truncate(seconds)} seconds. :P");