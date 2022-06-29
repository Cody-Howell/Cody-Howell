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
static void DrawMap(string[] screen){ //So I can have a second method.
    Console.Clear();
    foreach (string line in screen){
        Console.WriteLine(line);
    }
}

//Initialization
Random rand = new Random();
int map = 0; //Number representing which map should be up.
bool checkPointReached = false;
bool inMaze = false;
bool inBoss = false;
bool inBattle = false;
bool fromBattle = false;
bool dead = false;
bool winning = false;
int[] standing = new int[2];
int[] boss = new int[2] {0,0};
int health = 100;
int BATTLE = 0;
int enemyCount = 0;
int bossCount = 0;
Stopwatch stopwatch = new Stopwatch();


Console.Clear();

Console.WriteLine(@"Hello, and welcome to the game. You are a [sprite not found], wandering around a map.
You'll have to defeat random enemies, solve a maze, and beat the boss at the end. Good luck!
Press any key to begin.");
Console.ReadKey(true);
stopwatch.Start();

do {
    string[] screen = new string[20]; //This was placed inside the loop to continually draw the maps used.
    string[] mapPath = new string[7] {"Map.txt" , "Maze 1.txt" , "Maze 2.txt" , "Maze 3.txt" , "Maze 4.txt" , "Boss.txt" , "Random Encounters.txt"};
    screen = File.ReadAllLines(mapPath[map]);
    DrawMap(screen);
    //This section is the complicated bit about where you came from, and where you should go.
    if (fromBattle == true){Console.CursorTop = standing[0]; Console.CursorLeft = standing[1]; fromBattle = false;}
    else if (checkPointReached == false){Console.CursorTop = 3; Console.CursorLeft = 4;}
    else if (map == 5){Console.CursorTop = 16; Console.CursorLeft = 24;}
    else if (map > 0 && map < 5 && inBoss == true){standing[0] = 3; standing[1] = 1;} //One for the new boss rooms.
    else if (map > 0 && map < 5 && inMaze == false){Console.CursorTop = 1; Console.CursorLeft = 1; inMaze = true;}
    else {Console.CursorTop = 8; Console.CursorLeft = 52;} // Placement for checkpoints

    //Putting boss stuff here. Copying movement to avoid that mess, hopefully doesn't break too much. Put above the previous stuff to make sure the map was drawn first, and to avoid softlocks.
    while (inBoss == true && map != 5 && dead == false){
        Console.CursorTop = standing[0]; Console.CursorLeft = standing[1];
        var dir = Console.ReadKey(true).Key; 
        switch (dir){ 
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
        }
        standing[0] = Console.CursorTop; standing[1] = Console.CursorLeft;
        //Boss movements. Pretty much just chasing you in the shortest way. He doesn't care about walls and will just break them. He does not stop. You get like 4 spaces to work with.
        Console.CursorTop = boss[0]; Console.CursorLeft = boss[1]; Console.Write(" "); //Empty his spot.
        int upDown = Math.Abs(standing[0] - boss[0]);
        int leftRight = Math.Abs(standing[1] - boss[1]); //Which distance is longer?
        if (upDown >= leftRight){
            if (boss[0] > standing[0]) {boss[0]--;}
            else {boss[0]++;}
        }
        else {
            if (boss[1] > standing[1]) {boss[1]--;}
            else {boss[1]++;}
        }
        if (boss[0] == standing[0] && boss[1] == standing[1]) {//If you're in the same spot, you're dead.
            dead = true; 
            Console.Clear();
            Console.WriteLine("He got you! Learn his tricks to avoid death.");
            Console.WriteLine("Press a key to respawn.");
            Console.ReadKey(true);
            health = 100;
            map = 0;
            inBoss = false;
            break;
            
        } 
        else { //Actually moving him. 
            Console.CursorTop = boss[0]; Console.CursorLeft = boss[1]; Console.Write("!");
        }

        if (screen[Console.CursorTop][Console.CursorLeft] == '*' && inBoss == true){
            winning = true;
            stopwatch.Stop();
            break;
        }
    }
    
    while (true && winning == false && dead == false){ //added winning == false as a safeguard, now that you can win in lines above this. Same for death.
        if (inBoss == true && map != 5){break;} 
        var dir = Console.ReadKey(true).Key; 
        switch (dir){ //Second stolen thing, going to clean it with a Switch function.
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

        if (screen[Console.CursorTop][Console.CursorLeft] == '!'){ //Theoretically these could all be else if's, but I'm scared that might break something.
            Console.Clear();
            Console.WriteLine("You died! Don't touch those => !");
            Console.WriteLine("Press a key to respawn.");
            Console.ReadKey(true);
            health = 100;
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
        if (screen[Console.CursorTop][Console.CursorLeft] == '$' && checkPointReached == true){ //getting into the boss rooms.
            inBoss = true;
            bossCount++;
            if (bossCount >= 4){map = 5; break;} //If you've been through 3 mazes and haven't beaten it, you get to go to the room I spent all my time making.
            else {
                int temp = rand.Next(1,4);
                switch (temp){ 
                    case 1: map = 1; break;
                    case 2: map = 2; break;
                    case 3: map = 3; break;
                    case 4: map = 4; break;
                }
            break;
            }
        }
        if (screen[Console.CursorTop][Console.CursorLeft] == '*'){ 
            checkPointReached = true;
            map = rand.Next(1,4); 
            break;
        }
        //Check to see if a random encounter should happen.
        BATTLE = rand.Next(1,30);
        if (BATTLE == 6 && map == 0){
            break;
        }
    }

    //Start of the random encounter stuff.
    if (BATTLE == 6 && map == 0){
        enemyCount++;
        standing[0] = Console.CursorTop;
        standing[1] = Console.CursorLeft; //Saving a checkpoint for respawning at the same spot.
        screen = File.ReadAllLines(mapPath[6]);
        Console.Clear();
        DrawMap(screen);
        inBattle = true;
        int enemyHealth = rand.Next(20,40);

        do {
            Console.CursorTop = 12; Console.CursorLeft = 35;
            Console.WriteLine(health + " ");
            Console.CursorTop = 4; Console.CursorLeft = 20;
            Console.WriteLine(enemyHealth + "  "); //Placing health inside the graphics.
            
            int attack = rand.Next(5,15); //Variable every time.
            Console.CursorTop = 17; Console.CursorLeft = 0;
            Console.WriteLine("What would you like to do? Attack, defend, or heal?");
            string answer = ""; 
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
                    Console.CursorTop = 18; Console.CursorLeft = 0;
                    Console.WriteLine("                         ");
                    Console.CursorTop = 18; Console.CursorLeft = 0;
                    answer = Console.ReadLine().ToLower(); 
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
                health += rand.Next(15,25); //Needed a major buff.
                attack = 0;
                if (health > 100){health = 100;}
            }

            //Console.WriteLine(health + " " + enemyAttack + " " + enemyHealth + " " + attack + "        "); Debug line.
            health -= enemyAttack; //I thought about adding critical hits. No.
            enemyHealth -= attack;

            if (enemyHealth <= 0){
                inBattle = false;
                map = 0;
            }
            if (health <= 0){
                inBattle = false;
                checkPointReached = false;
                map = 0;
                break;
            }

            Console.CursorTop = 18; Console.CursorLeft = 0;
            Console.WriteLine("                         "); //Erases the writing line.

        } while (inBattle == true);

        map = 0;
        fromBattle = true;
        if (health <= 0){
            Console.Clear();
            Console.WriteLine("You Died from Random Encounter. Press a key to continue."); 
            Console.ReadKey(true);
            fromBattle = false;
            map = 0; 
            checkPointReached = false; 
            health = 100; 
            continue;
        }
    }
    boss[0] = 0; boss[1] = 0; //Reset the boss position.
    dead = false; //I think I can just chuck this down here as a safety measure.
} while (winning == false);

Console.Clear();
double seconds = stopwatch.ElapsedMilliseconds / 1000.0;
Console.WriteLine($"Congrats! You won. It only took you {seconds} seconds. :P"); //Made it so you can see milliseconds.