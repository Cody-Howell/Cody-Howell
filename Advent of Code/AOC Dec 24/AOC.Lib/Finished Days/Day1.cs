namespace AOC.Lib.Day1; 
public static class Program {
    public static int GetTotalDistance(List<int> list1, List<int> list2) {
        int totalDistance = 0;
        int length = list1.Count;
        for (int i = 0; i < length; i++) {
            totalDistance += Math.Abs(GetAndRemoveLowestValue(list1) - GetAndRemoveLowestValue(list2));
        }

        return totalDistance;
    }

    public static int GetSimilarityScore(List<int> list1, List<int> list2) {
        int score = 0;
        foreach (int i in list1) {
            score += GetNumOfRepetitions(i, list2) * i;
        }
        return score;
    }

    public static int GetNumOfRepetitions(int value, List<int> list) {
        int count = 0;
        foreach (int item in list) {
            if (item == value) count++;
        }
        return count;
    }

    public static int GetAndRemoveLowestValue(List<int> list) {
        int lowestIndex = 0;
        for (int i = 1; i < list.Count; i++) {
            if (list[i] < list[lowestIndex]) {
                lowestIndex = i;
            }
        }
        int value = list[lowestIndex];
        list.RemoveAt(lowestIndex);
        return value;
    }
}
