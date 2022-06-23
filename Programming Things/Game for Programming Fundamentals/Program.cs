﻿using System.Diagnostics;

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
bool inBattle = false;
bool fromBattle = false;
bool winning = false;
int[] standing = new int[2];
bool dead = true;
int health = 100;
int BATTLE = 0;
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
    
    if (fromBattle == true){Console.CursorTop = standing[0]; Console.CursorLeft = standing[1]; fromBattle = false;}
    else if (checkPointReached == false){Console.CursorTop = 3; Console.CursorLeft = 4;}
    else if (map == 5){Console.CursorTop = 16; Console.CursorLeft = 24;}
    else if (map > 0 && map < 5 && inMaze == false){Console.CursorTop = 1; Console.CursorLeft = 1; inMaze = true;}
    else {Console.CursorTop = 8; Console.CursorLeft = 52;} // Placement for checkpoints

    while (true){
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
            checkPointReached = true;
            map = rand.Next(1,4); 
            break;
        }
        BATTLE = rand.Next(1,30);
        if (BATTLE == 6 && map == 0){
            break;
        }
    }
    //Start of the random encounter stuff.
    if (BATTLE == 6 && map == 0){
        if (health <= 0){
            Console.Clear();
            Console.WriteLine("You Died from Random Encounter. Press a key to continue."); 
            Console.ReadKey(true);
            map = 0; 
            checkPointReached = false; 
            health = 100; 
            continue;
        }
        standing[0] = Console.CursorTop;
        standing[1] = Console.CursorLeft;
        screen = File.ReadAllLines(mapPath[6]);
        Console.Clear();
        foreach (string line in screen){
            Console.WriteLine(line);
        }
        inBattle = true;
        int enemyHealth = rand.Next(20,50);

        do {
            Console.CursorTop = 12; Console.CursorLeft = 35;
            Console.WriteLine(health + " ");
            Console.CursorTop = 4; Console.CursorLeft = 20;
            Console.WriteLine(enemyHealth + "  ");
            
            dead = false;
            int attack = rand.Next(5,15);
            Console.CursorTop = 17;
            Console.CursorLeft = 0;
            Console.WriteLine("What would you like to do? Attack, defend, or heal?");
            string answer = Console.ReadLine().ToLower(); 
            bool correct = false; //this is just something dumb to check if they put in an apropriate answer.
            while (correct == false){
                switch (answer) {
                case "attack":
                    correct = true;
                    break;
                case "defend":
                    correct = true;
                    break;
                case "heal":
                    correct = true;
                    break;
                default:
                    break;
                }
            }
            int eC = rand.Next(1,2); //Shortened "EnemyChoice" for the string conversion in a sec.
            int enemyAttack = rand.Next(5,10);
            string enemyChoice = "";
            switch (eC){
                case 1:
                    enemyChoice = "attack";
                    break;
                case 2:
                    enemyChoice = "defend";
                    break;  
            } 
            
            if (enemyChoice == "defend"){
                attack /= 2;
                enemyAttack = 0;
            }
            if (answer == "defend"){
                enemyAttack /= (2 * eC);
                attack = 0;
            }
            else if (answer == "heal"){
                health += rand.Next(20,30); //Needed a major buff.
                attack = 0;
            }
            Console.WriteLine(health + " " + enemyAttack + " " + enemyHealth + " " + attack + "        ");
            health -= enemyAttack; //I thought about adding critical hits. No.
            enemyHealth -= attack;

            if (enemyHealth <= 0){
                inBattle = false;
                dead = false;
                map = 0;
            }
            if (health <= 0){
                inBattle = false;
                dead = true;
                checkPointReached = false;
                map = 0;
                break;
            }

            Console.CursorTop = 18;
            Console.CursorLeft = 0;
            Console.WriteLine("                         "); //Erases the writing line.

        } while (inBattle == true);
        map = 0;
        fromBattle = true;
    }
} while (winning == false);

Console.Clear();
double seconds = stopwatch.ElapsedMilliseconds / 1000.0;
Console.WriteLine($"Congrats! You won. It only took you {Math.Truncate(seconds)} seconds. :P");