﻿using System;

namespace ExceptionHandling2
{
    public static class IntConverter
    {
        public static int ConvertToInt(string sourceString)
        {
            try
            {
                return Convert.ToInt32(sourceString);
            }
            catch (FormatException)
            {
                throw;
            }
        }
    }
}
