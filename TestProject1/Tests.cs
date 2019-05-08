﻿using System;
using Xunit;

namespace TestProject1
{
    
    public class CustomPrint
    {
        public string GetValue(int num)
        {
            if (num % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (num % 3 == 0)
            {
                return "Fizz";
            }
            if (num % 5 == 0)
            {
                return "Buzz";
            }
            return String.Empty;
        }

        public void Print(int input)
        {
           Console.WriteLine(GetValue(input));
        }
    }
    
    public class Tests
    {
        [Fact]
        public void when_number_is_times_of_3_return_Fizz()
        {
            var printer = new CustomPrint();
            Assert.Equal("Fizz", printer.GetValue(3));
            Assert.NotEqual("Fizz", printer.GetValue(4));
        }

        [Fact]
        public void when_number_is_times_of_5_return_Buzz()
        {
            var printer = new CustomPrint();
            Assert.Equal("Buzz", printer.GetValue(10));
            Assert.NotEqual("Buzz", printer.GetValue(9));
        }

        [Fact]
        public void when_number_is_times_of_3_and_5_return_FizzBuzz()
        {
            var printer = new CustomPrint();
            Assert.Equal("FizzBuzz", printer.GetValue(15));
            Assert.NotEqual("FizzBuzz", printer.GetValue(20));
        }
    }
}