using NUnit.Framework;

namespace Katy_NUnitFirstProject
{
    
    public class Tests
    {
       
        [Test, Description("Check Plus"), TestCaseSource("DivideCases1")]
        public void Test1(int x, int y, int s)
        {
            int temp = Calc.Plus(x, y);
            Assert.AreEqual(s, temp);
        }
        static object[] DivideCases1 =
        {
            new object[] { 5, -7, -2 },
            new object[] { 10, 2, 12 },
            new object[] { 12, 4, 16 }
        };

        [Test, Description("Check Minus"), TestCaseSource("DivideCases2")]
        public void Test2(int x, int y, int s)
        {
            int temp = Calc.Minus(x, y);
            Assert.AreEqual(s, temp);
        }
        static object[] DivideCases2 =
        {
            new object[] { -5, -7, 2 },
            new object[] { 10, 2, 8 },
            new object[] { 2, 14, -12 }
        };

        [Test, Description("Check Multiplication"), TestCaseSource("DivideCases3")]
        public void Test3(int x, int y, int s)
        {
            int temp = Calc.Multiplication(x, y);
            Assert.AreEqual(s, temp);
        }
        static object[] DivideCases3 =
        {
            new object[] { 3, 2, 6 },
            new object[] { -10, -5, 50 },
            new object[] { -2, 0, 0 }
        };

        [Test, Description("Check Division"), TestCaseSource("DivideCases4")]
        public void Test4(int x, int y, int s)
        {
            int temp = Calc.Division(x, y);
            Assert.AreEqual(s, temp);
        }
        static object[] DivideCases4 =
        {
            new object[] { 3, 0, 0 },
            new object[] { 20, -5, -4 },
            new object[] { 10, 5, 2 }
        };
    }
    

}
