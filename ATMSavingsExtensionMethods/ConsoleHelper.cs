using System;

namespace ATMSavingsExtensionMethods
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";
            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }
            return output;
        }

        public static decimal RequestDecimal(this string message)
        {
            return message.RequestDecimal(false);

        }
        public static decimal RequestDecimal(this string message, int minValue, int maxValue)
        {
            return message.RequestDecimal(true, minValue, maxValue);
        }
        public static decimal RequestDecimal(this string message, bool useMinMax, int minValue = 0, int maxValue = 20000)
        {
            decimal output = 0;
            bool isValidDecimal = false;
            bool isInRange = false;
            while (isValidDecimal == false || isInRange == false)
            {
                Console.Write(message);
                isValidDecimal = decimal.TryParse(Console.ReadLine(), out output);
                if (useMinMax == true)
                {
                    isInRange = (output >= minValue && output <= maxValue);
                }
            }
            return output;

        }

    }



}
