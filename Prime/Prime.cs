namespace prime
{
    public static class Prime
    {
        public static bool IsPrime(int candidate)
        {
            for(var x = 2; x < candidate; x++)
            {
                var remainder = (candidate % x);
                if (remainder == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
