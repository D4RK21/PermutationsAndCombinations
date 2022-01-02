namespace PermutationsAndCombinations
{
    class Combinations
    {
        private static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        public static int GenerateCombinations(int n, int m)
        {
            int result;
            result = Factorial(n + m - 1) / (Factorial(m) * Factorial(n - 1));
            return result;
        }
    }
}
