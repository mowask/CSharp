using Fastenshtein;

internal class Program
{
    private static void Main(string[] args)
    {
        string testString1 = "ALL";
        string testString2 = "BALL";

        //Haming
        int distance = GetHammingDistance(testString1, testString2);
        Console.WriteLine(distance);

        //Levenshtein
        int distance2 = Levenshtein.Distance(testString1, testString2);
        Console.WriteLine(distance2);

    }

    private static int GetHammingDistance(string first, string second)
    {
        int count = 0;
        int minLenth = Math.Min(first.Length, second.Length);
        for (int i = 0; i < minLenth; i++)
        {
            if (first[i] != second[i])
                count++;
        }
        return count + Math.Abs(first.Length-second.Length);
    }
}