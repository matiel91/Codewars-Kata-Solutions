using Create_Phone_Number;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePhoneNumber.tests
{
    [TestFixture]
    public class PhoneNumberCrteatorTest
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, Result = "(123) 456-7890")]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, Result = "(111) 111-1111")]
        public string PhoneNumberCreatedProperly(int[] array)
        {

            var result = Kata.CreatePhoneNumber(array);
            return result; //w tym wypadku kompilator asertuje sam

        }

    }
}

