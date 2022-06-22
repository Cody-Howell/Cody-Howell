/* Date: July 27 2022
Name: Cody Howell
Lab: Final Project */

//Methods

//Initialization
Random rand = new Random();
string Overworld = @"Map.txt";
string Maze_1 = @"Maze 1.txt";
string Maze_2 = @"Maze 2.txt";
string Maze_3 = @"Maze 3.txt";
string Maze_4 = @"Maze 4.txt";
string Boss = @"Boss.txt";
string randEncount = @"Random Encounters.txt";
bool checkPointReached = false;
bool inMaze = false;
bool dead = false;
bool oppDead = false;
int health = 100;
int attack = rand.Next(5,15);



















Console.Clear();

Console.WriteLine(@"Hello, and welcome to the game. You are a [sprite not found], wandering around a map.
You'll have to defeat random enemies, solve a maze, and beat the boss at the end. Good luck!
Press any key to begin.");
Console.ReadKey(true);
Console.Clear();

string[] screen = new string[20];
screen = File.ReadAllLines(Boss);
foreach (string line in screen){
    Console.WriteLine(line);
}
