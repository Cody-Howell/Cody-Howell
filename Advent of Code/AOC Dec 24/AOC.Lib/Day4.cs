namespace AOC.Lib.Day4;

public static class Program {
    public static int CountXMAS(string s) {
        string[] arr = s.Split('\n');
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = arr[i].Trim();
        }

        return CountHorizontal(arr) + CountVertical(arr) +
            CountUpLeftDiagonal(arr) + CountUpRightDiagonal(arr);
    }

    public static int CountHorizontal(string[] s) {
        int count = 0;
        for (int i = 0; i < s.Count(); i++) {
            for (int j = 0; j < s[i].Length - 3; j++) {
                if (s[i][j] == 'X' &&
                    s[i][j + 1] == 'M' &&
                    s[i][j + 2] == 'A' &&
                    s[i][j + 3] == 'S' ||
                    s[i][j] == 'S' &&
                    s[i][j + 1] == 'A' &&
                    s[i][j + 2] == 'M' &&
                    s[i][j + 3] == 'X'
                    ) {
                    count++;
                }
            }
        }
        return count;
    }

    public static int CountVertical(string[] s) {
        int count = 0;
        for (int i = 0; i < s.Count() - 3; i++) {
            for (int j = 0; j < s[i].Length; j++) {
                if (s[i][j] == 'X' &&
                    s[i + 1][j] == 'M' &&
                    s[i + 2][j] == 'A' &&
                    s[i + 3][j] == 'S' ||
                    s[i][j] == 'S' &&
                    s[i + 1][j] == 'A' &&
                    s[i + 2][j] == 'M' &&
                    s[i + 3][j] == 'X'
                    ) {
                    count++;
                }
            }
        }
        return count;
    }

    public static int CountUpLeftDiagonal(string[] s) {
        int count = 0;
        for (int i = 0; i < s.Count() - 3; i++) {
            for (int j = 0; j < s[i].Length - 3; j++) {
                if (s[i][j] == 'X' &&
                    s[i + 1][j + 1] == 'M' &&
                    s[i + 2][j + 2] == 'A' &&
                    s[i + 3][j + 3] == 'S' ||
                    s[i][j] == 'S' &&
                    s[i + 1][j + 1] == 'A' &&
                    s[i + 2][j + 2] == 'M' &&
                    s[i + 3][j + 3] == 'X'
                    ) {
                    count++;
                }
            }
        }
        return count;
    }

    public static int CountUpRightDiagonal(string[] s) {
        int count = 0;
        for (int i = 0; i < s.Count() - 3; i++) {
            for (int j = 3; j < s[i].Length; j++) {
                if (s[i][j] == 'X' &&
                    s[i + 1][j - 1] == 'M' &&
                    s[i + 2][j - 2] == 'A' &&
                    s[i + 3][j - 3] == 'S' ||
                    s[i][j] == 'S' &&
                    s[i + 1][j - 1] == 'A' &&
                    s[i + 2][j - 2] == 'M' &&
                    s[i + 3][j - 3] == 'X'
                    ) {
                    count++;
                }
            }
        }
        return count;
    }

    public static int CountX_MAS(string s) {
        string[] arr = s.Split('\n');
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = arr[i].Trim();
        }

        int count = 0;
        for (int i = 1; i < arr.Length - 1; i++) {
            for (int j = 1; j < arr[i].Length - 1; j++) {
                if (IsXCross(arr, j, i)) {
                    count++;
                }
            }
        }

        return count;
    }

    private static bool IsXCross(string[] s, int x, int y) {
        if (s[y][x] == 'A') {
            if (s[y - 1][x - 1] == 'M' &&
                s[y + 1][x + 1] == 'S' ||
                s[y - 1][x - 1] == 'S' &&
                s[y + 1][x + 1] == 'M') {
                if (s[y - 1][x + 1] == 'M' &&
                    s[y + 1][x - 1] == 'S' ||
                    s[y - 1][x + 1] == 'S' &&
                    s[y + 1][x - 1] == 'M') {
                    return true;
                }
            }
        }
        return false;
    }
}
