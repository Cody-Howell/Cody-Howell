string[] data = File.ReadAllLines("./test.txt");
// string[] data = File.ReadAllLines("./data.txt");
int point = 50;
int actualAnswer = 0;

foreach (string line in data) {
    char LorR = line[0];
    int amount = int.Parse(line.Substring(1));
    if (LorR == 'R') {
        point += amount;
    } else {
        point -= amount;
    }
    Console.WriteLine(point);
    Console.WriteLine(actualAnswer);

    while (point >= 100) {point -= 100; actualAnswer++;}
    Console.WriteLine(actualAnswer);
    while (point < 0) {point += 100; actualAnswer++;}
    Console.WriteLine(actualAnswer);

    if (point == 0) {
        actualAnswer++;
    }
    Console.WriteLine($"---{point}----");
}

Console.WriteLine(actualAnswer);