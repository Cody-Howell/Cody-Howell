namespace AOC.Lib.Day2;
public static class Program {
    public static int CountSafeValues(string values, bool allow1Out) {
        string[] strings = values.Trim().Split("\r\n");
        int count = 0;

        foreach (string s in strings) {
            int[] ints = s.Split(' ').Select(int.Parse).ToArray();
            bool result = false;
            if (allow1Out) {
                result = ValidateSafetyWith1Removal(ints);
            } else {
                result = ValidateSafety(ints);
            }
            if (result) {
                count++;
            }
        }
        return count;
    }

    public static bool ValidateSafety(int[] vals) {
        bool? ascending = null;
        for (int i = 0; i < vals.Length - 1; i++) {
            int output = vals[i] - vals[i + 1];
            if (Math.Abs(output) > 3 || output == 0) {
                return false;
            }
            if (ascending == null) {
                ascending = AssignDirection(output);
            } else {
                bool value = AssignDirection(output);
                if (value != ascending) {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool ValidateSafetyWith1Removal(int[] vals) {
        if (ValidateSafety(vals)) {
            return true;
        }

        List<int> ints = new List<int>(vals);
        for (int i = 0; i < ints.Count; i++) {
            ints.RemoveAt(i);
            if (ValidateSafety(ints.ToArray())) {
                return true;
            }
            ints = new List<int>(vals);
        }
        return false;
    }

    private static bool AssignDirection(int value) {
        return value > 0 ? true : false;
    }
}
