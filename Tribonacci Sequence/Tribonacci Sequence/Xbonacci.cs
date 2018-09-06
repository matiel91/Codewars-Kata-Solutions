namespace Tribonacci_Sequence
{
    /// <summary>
    /// Tribonacci Sequence
    /// Well met with Fibonacci bigger brother, AKA Tribonacci.
    /// As the name may already reveal, it works basically like a Fibonacci, but summing the last 3 (instead of 2) numbers of the sequence to generate the next.
    /// </summary>
    public class Xbonacci
    {

        /// <summary>
        /// Method takes array of numbers and returning n-element array of "Tribonacci sequence" 
        /// </summary>
        /// <param name="signature">Input array</param>
        /// <param name="n">Numbers of element in tribonacci sequnce</param>
        /// <returns>Returning n-element array (double[]) of "Tribonacci sequence" </returns>
        public double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
            {
                return new double[1] {0};
            }
            double[] resultArray = new double[n];
            if (n>0 && n<4)
            {
                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultArray[i] = signature[i];
                }
                return resultArray;
            }
            resultArray[0] = signature[0];
            resultArray[1] = signature[1];
            resultArray[2] = signature[2];
            for (int i = 3; i <resultArray.Length; i++)
            {
                resultArray[i] = resultArray[i - 3] + resultArray[i - 2] + resultArray[i - 1];
            }

            return resultArray;
        }
    }
}
