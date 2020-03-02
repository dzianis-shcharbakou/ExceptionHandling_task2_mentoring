using System;

namespace ExceptionHandling2
{
    public static class IntConverter
    {
        public static int ConvertStringToInt(string sourceString)
        {
            if (sourceString.Length == 0) throw new FormatException("Exception: String length cannot be 0!");
            bool isNegative = false;
            int begin = 0;
            switch (sourceString[0])
            {
                case '-':
                    if (sourceString.Length == 1) throw new FormatException("Exception: String cannot contain only one arithmetic sign!");
                    begin = 1;
                    isNegative = true;
                    break;
                case '+':
                    if (sourceString.Length == 1) throw new FormatException("Exception: String cannot contain only one arithmetic sign!");
                    begin = 1;
                    break;
            }
            int result = 0;
            for (int i = begin; i < sourceString.Length; i++)
            {
                char c = sourceString[i];
                if (c < '0' || c > '9') throw new FormatException("Exception: String must contain only numbers!");
                result = result * 10 + (c - '0');
            }
            return (isNegative) ? -result : result;
        }
    }
}
