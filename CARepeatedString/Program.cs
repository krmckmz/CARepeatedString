namespace ConsoleApp1
{
    internal class Program
    {
        const char specificChar = 'a';

        static void Main(string[] args)
        {
            long charCount = 10;
            string givenWord = "abcac";
            long stepCount = GetCaseCount(givenWord, charCount);
            Console.WriteLine(stepCount);

            Console.ReadLine();
        }

        public static long GetCaseCount(string givenWord, long charCount)
        {
            var givenWordLength = givenWord.Length;
            long mod = charCount % givenWordLength;
            long division = charCount / givenWordLength;

            var caseCountInGivenWord = givenWord.Count(f => f == specificChar);
            var constantCaseCountInGivenWord = division * caseCountInGivenWord;

            if (mod == 0)
                return constantCaseCountInGivenWord;
            else
            {
                var residualWord = givenWord.Substring(Convert.ToInt32(0), Convert.ToInt32(mod));
                var specificCaseCountInResidiualWord = residualWord.Count(f => f == specificChar);

                return constantCaseCountInGivenWord + specificCaseCountInResidiualWord;
            }
        }
    }
}