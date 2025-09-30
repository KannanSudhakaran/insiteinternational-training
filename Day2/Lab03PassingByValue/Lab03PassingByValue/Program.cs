


class Program
{

   
    static void Main() {

          //CaseStudy1();

        CaseStudy2();

    }

     static void CaseStudy2()
    {
        int[] manyScores = new int[]{ 50,60,70 };
        Console.WriteLine(manyScores.GetHashCode());
        UpdateTheScoreToZero(manyScores);
        foreach (int temp in manyScores)
        {
            Console.WriteLine(temp);
        }

    }

     static void CaseStudy1()
    {
        Console.WriteLine("casestudy1");
        int myScore = 100;
        UpdateTheScoreToZero(myScore);
        Console.WriteLine(myScore);

    }

    static void UpdateTheScoreToZero(int score) {
        score = 0;
    }

    static void UpdateTheScoreToZero(int[] scores) {
        Console.WriteLine(scores.GetHashCode());
        for (int index = 0; index < scores.Length; index++) {
            scores[index] = 0;
        }
    }
}