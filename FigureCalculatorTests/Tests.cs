using System;
using FigureCalculator.Entity;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace FigureCalculatorTests
{
    
    public class Tests
    {
        [Fact]
        public void Calculate_Triangle_Square_Expect_Six()
        {
            //preparation
            Triangle triangle = new(4, 3, 5);
            double expect = 6;

            //action
            double actual = triangle.GetSquare();
            
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Fact]
        public void Calculate_Circle_Square()
        {
            //preparation
            Circle circle = new(4);
            double expect = 50.265;
            
            //action
            double actual = Math.Round(circle.GetSquare(),3);
            
            //assert
            Assert.AreEqual(expect,actual);
        }
    }
}