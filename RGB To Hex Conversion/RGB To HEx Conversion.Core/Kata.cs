using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_To_HEx_Conversion.Core
{
    /// <summary>
    /// RGB to hex conversion
    /// The rgb() method is incomplete. Complete the method so that passing in RGB decimal values will result in a hexadecimal representation being returned. 
    /// The valid decimal values for RGB are 0 - 255. Any (r,g,b) argument values that fall out of that range should be rounded to the closest valid value.
    /// </summary>
    public class Kata
    {
        public static string Rgb(int v1, int v2, int v3)
        {
            return DecToHexConverter2(v1) + DecToHexConverter2(v2) + DecToHexConverter2(v3);
        }

        //1st solution, convertion step by step
        public static string DecToHexConverter(int input)
        {
            if(input >= 255)
            {
                return "FF";
            }
            if(input <= 0)
            {
                return "00";
            }

            int residual;
            string output = "";
            while (input != 0)
            {
                residual = input % 16;
                input /= 16;
                if (residual > 9)
                {
                    switch (residual)
                    {
                        case 10:
                            output = "A" + output;
                            break;
                        case 11:
                            output = "B" + output;
                            break;
                        case 12:
                            output = "C" + output;
                            break;
                        case 13:
                            output = "D" + output;
                            break;
                        case 14:
                            output = "E" + output;
                            break;
                        case 15:
                            output = "F" + output;
                            break;
                        default:
                            throw new Exception("Something Wrong");
                    }
                }
                else
                {
                    output = residual + output;
                }
            }
            return output.Length == 2 ? output : "0" + output;
        }

        //2nd solution with using ToString("X2") to convert
        public static string DecToHexConverter2(int input)
        {
            if (input >= 255)
            {
                return "FF";
            }
            if (input <= 0)
            {
                return "00";
            }

            return input.ToString("X2");
        }

    }
}
