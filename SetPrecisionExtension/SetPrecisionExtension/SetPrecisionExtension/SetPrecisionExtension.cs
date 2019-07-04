using System;
using System.Text;

namespace SetPrecisionExtensions
{
    public static class SetPrecisionExtension
    {
        public static string SetPrecision(this float num, int precision)
        {
            try
            {
                if (precision == 0)
                {
                    return ((int)Math.Round(num)).ToString();
                }
                string numberString = num.ToString();
                int lastIndex = numberString.IndexOf(".") + precision;
                if (lastIndex + 1 >= numberString.Length)
                {
                    return numberString;
                }
                if (Convert.ToInt32(numberString[lastIndex + 1]) > 4)
                {
                    var str = new StringBuilder(numberString);
                    str[lastIndex] = char.Parse((Convert.ToInt32(numberString[lastIndex].ToString()) + 1).ToString());
                    numberString = str.ToString();
                }
                return numberString.Substring(0, numberString.IndexOf(".") + precision + 1);
            }
            catch (FormatException)
            {
                Console.WriteLine("The precision is invalid!");
                return num.ToString();
            }
        }
    }
}
