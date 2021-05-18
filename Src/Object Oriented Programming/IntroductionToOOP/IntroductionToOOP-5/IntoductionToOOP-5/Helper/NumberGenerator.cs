using System;
using IntoductionToOOP_5.Interfaces;

namespace IntoductionToOOP_5.Helper
{
    public class NumberGenerator : INumberGenerator
    {
        public int CreateNumber()
        {
            var random = new Random();
            var number = random.Next(0, 9);

            return number;

        }
    }
}