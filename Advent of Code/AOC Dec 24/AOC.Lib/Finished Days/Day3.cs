namespace AOC.Lib.Day3; 
public static class Program {
    public static int GetMultipliedValues(string s) {
        int result = 0;
        int firstIndex = FindIndexOfMul(s, 0);
        while (firstIndex != -1) {
            int comma = FindIndexOfChar(s, ',', firstIndex);
            if (comma != -1) {
                int closingParenthesis = FindIndexOfChar(s, ')', firstIndex);
                if (closingParenthesis != -1) {
                    int firstSpace = FindIndexOfChar(s, ' ', firstIndex);
                    if ((firstSpace == -1 || firstSpace > closingParenthesis) && closingParenthesis > comma) {
                        string s1 = s.Substring(firstIndex, comma - firstIndex);
                        string s2 = s.Substring(comma + 1, closingParenthesis - 1 - comma);

                        int firstNum;
                        int secondNum;

                        bool b1 = int.TryParse(s1, out firstNum);
                        bool b2 = int.TryParse(s2, out secondNum);

                        if (b1 && b2) {
                            result += firstNum * secondNum;
                        }
                    }
                }
            }
            firstIndex = FindIndexOfMul(s, firstIndex);
            continue;
        }

        return result;
    }

    public static int GetMultipliedValuesDosAndDonts(string s) {
        int result = 0;
        int firstIndex = FindIndexOfMul(s, 0);
        int nextDo = FindIndexOfDo(s, 0);
        int nextDont = FindIndexOfDont(s, 0);
        while (firstIndex != -1) {
            if (nextDont < firstIndex && firstIndex < nextDo) {
                firstIndex = FindIndexOfMul(s, nextDo);
                nextDont = FindIndexOfDont(s, nextDo);
                nextDo = FindIndexOfDo(s, nextDo);
                continue;
            } else if (nextDo < nextDont && nextDont < firstIndex) {
                nextDo = FindIndexOfDo(s, firstIndex);
                nextDont = FindIndexOfDont(s, firstIndex);
                firstIndex = FindIndexOfMul(s, firstIndex);
                continue;
            }

            int comma = FindIndexOfChar(s, ',', firstIndex);
            if (comma != -1) {
                int closingParenthesis = FindIndexOfChar(s, ')', firstIndex);
                if (closingParenthesis != -1) {
                    int firstSpace = FindIndexOfChar(s, ' ', firstIndex);
                    if ((firstSpace == -1 || firstSpace > closingParenthesis) && closingParenthesis > comma) {
                        string s1 = s.Substring(firstIndex, comma - firstIndex);
                        string s2 = s.Substring(comma + 1, closingParenthesis - 1 - comma);

                        int firstNum;
                        int secondNum;

                        bool b1 = int.TryParse(s1, out firstNum);
                        bool b2 = int.TryParse(s2, out secondNum);

                        if (b1 && b2) {
                            result += firstNum * secondNum;
                        }
                    }
                }
            }
            nextDo = FindIndexOfDo(s, firstIndex);
            nextDont = FindIndexOfDont(s, firstIndex);
            firstIndex = FindIndexOfMul(s, firstIndex);
        }

        return result;
    }

    public static int FindIndexOfMul(string s, int start = 0) { // Starts at end of first (
        for (int i = start; i < s.Length - 3; i++) {
            if (s[i] == 'm' &&
                s[i + 1] == 'u' && 
                s[i + 2] == 'l' && 
                s[i + 3] == '(') {
                return i + 4;
            }
        }
        return -1;
    }

    private static int FindIndexOfDo(string s, int start = 0) {
        for (int i = start; i < s.Length - 3; i++) {
            if (s[i] == 'd' &&
                s[i + 1] == 'o' &&
                s[i + 2] == '(' &&
                s[i + 3] == ')') {
                return i + 4;
            }
        }
        return -1;
    }

    private static int FindIndexOfDont(string s, int start = 0) {
        for (int i = start; i < s.Length - 6; i++) {
            if (s[i] == 'd' &&
                s[i + 1] == 'o' &&
                s[i + 2] == 'n' &&
                s[i + 3] == '\'' &&
                s[i + 4] == 't' &&
                s[i + 5] == '(' &&
                s[i + 6] == ')') {
                return i + 7;
            }
        }
        return -1;
    }

    private static int FindIndexOfChar(string s, char c, int start = 0) {
        for (int i = start; i <  s.Length; i++) {
            if (s[i] == c) {
                return i;
            }
        }
        return -1;
    }
}
