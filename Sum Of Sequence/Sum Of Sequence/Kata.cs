namespace Sum_Of_Sequence
{
    /// <summary>
    /// Your task is to make function, which returns the sum of a sequence of integers.
    /// The sequence is defined by 3 non-negative values: begin, end, step.
    /// </summary>
    public static class Kata
    {
        /// <summary>
        /// Function calculate the sum of a sequence of integers
        /// </summary>
        /// <param name="start">Begin Value</param>
        /// <param name="end">End Value</param>
        /// <param name="step">Step Value</param>
        /// <returns></returns>
        public static int SequenceSum(int start, int end, int step)
        {
            var sum = 0;
            if (start > end) return 0;
            for (int i = start; i <= end; i+=step)
            {
                sum += i;
            }
            return sum;
        }
    }
}
