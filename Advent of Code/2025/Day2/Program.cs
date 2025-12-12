string input = File.ReadAllText("./test.txt");
// string input = File.ReadAllText("./part1.txt");
string[] ranges = input.Split(',');
List<(long start, long end)> values = new();
foreach (string range in ranges) {
    string[] strings = range.Split('-');
    values.Add((long.Parse(strings[0]),long.Parse(strings[1]) ));
}

// Part 1
long sum1 = 0;
foreach ((long start, long end) value in values) {
    for (long i = value.start; i <= value.end; i++) {
        string part = i.ToString();
        if (part.Substring(0, part.Length / 2) == part.Substring(part.Length / 2)) {
            sum1 += i;
        }
    }
}

Console.WriteLine(sum1);

// Part 2
long sum2 = 0;
foreach ((long start, long end) value in values) {
    for (long i = value.start; i <= value.end; i++) {
        string part = i.ToString();
        bool works = true;
        for (int j = 1; j < part.Length / 2; j++) {
            string subset = part[..j];
            for (int k = 0; k < part.Length / j; k++) {
                if (part.Substring(k * j, (k + 1) * j) == part.Substring((k + 1) * j, (k + 2) * j)) {
                    works = false;
                }
            }
        }
        if (works) sum2 += i;
    }
}

Console.WriteLine(sum2);