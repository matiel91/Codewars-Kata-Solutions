namespace Create_Phone_Number
{
    /// <summary>
    /// Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
    /// Format: "(123) 456-7890"
    /// </summary>
    public static class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            if (numbers.Length != 10) {
                throw new System.Exception("Array lenght !=10");
            }
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        }

    }
}
