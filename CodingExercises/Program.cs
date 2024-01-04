public class Program
{
    static void Main()
    {
        string sequence = "1,2,1,1,0,3,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0";
        int longSQ = GetLongestSq(sequence);
        //Console.WriteLine(longSQ);
        //ExerciseTwo();
        Stars();
    }

    /**********Problem1*********/

    static int GetLongestSq(string sequence)
    {
        string[] sq = sequence.Split(',');
        int shortestSq = 0;
        int longestSQ = 0;
        foreach (string s in sq)
        {
            int dailySale = int.Parse(s);
            if (dailySale == 0)
            {
                shortestSq++;
            }
            else
            {
                longestSQ = Math.Max(longestSQ, shortestSq);
                shortestSq = 0;
            }
        }


        longestSQ = Math.Max(longestSQ, shortestSq);
        return longestSQ;
    }

    /**********Problem2*********/
    public static List<string> ExerciseTwo()
    {
        var dict = new List<string> { "parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray" };
        string target = "star";
        var result = new List<string>();

        foreach(string s in dict)
        { 
            var arr1 = s.ToCharArray();
            var arr2 = target.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            var sorted = new string(arr1);  
            var targetSorted = new string(arr2);
            if (sorted == targetSorted)
            {
                result.Add(s);
            }
        }
        Console.WriteLine("Anagrams: " + string.Join(", ", result));

        return result;

    }


    /**********Problem3*********/
    public static void Stars() 
    {
        char charToPrint = '*';
        int totalLines = 10;
        for(int i = 1; i <= totalLines; i+=2)
        {
            int spacesBefore = (totalLines - i) / 2;
            string lineP = new string(' ',spacesBefore) + new string(charToPrint, i);
            Console.WriteLine(lineP);
        }
    
    }


}
