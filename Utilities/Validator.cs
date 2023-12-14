using System;

namespace ImproveYourSchedule.Utilities
{
    public static class Validator
    {
        public static int CheckInValidRange(int value, int min, int max, string valueName)
        {
            if (value < min || value > max)
                throw new ArgumentOutOfRangeException($"Allowed int range: ({min}-{max}). Got: {value}", nameof(value));

            return value;
        }
        
        public static string CheckNullOrEmpty(string value, string valueName) =>
            !string.IsNullOrEmpty(value)
                ? value
                : throw new ArgumentException($"Cannot be null or empty!", valueName);
    }
}