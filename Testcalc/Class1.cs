using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;



namespace Testcalc
{
   
    public class Class1
    {
        [Test]

        public void TestSum()
        {
            var p = new zadanie2.Calculator();
            double test=p.Plus(5, 5);
            Assert.AreEqual(10,test);

        }
        [Test]

        public void TestSum2()
        {
            var p = new zadanie2.Calculator();
            double test = p.Plus(333, 666);
            Assert.AreEqual(999, test);

        }
        [Test]

        public void TestSum3()
        {
            var p = new zadanie2.Calculator();
            double test = p.Plus(45, -30);
            Assert.AreEqual(15, test);

        }
         [Test]
        public void TestDiv()
        {
            var p = new zadanie2.Calculator();
            double test = p.Division(6, 2);
            Assert.AreEqual(3, test);

        }
         [Test]
         public void TestDiv2()
         {
             var p = new zadanie2.Calculator();
             double test = p.Division(999, 333);
             Assert.AreEqual(3, test);

         }
         [Test]
         public void TestDiv3()
         {
             var p = new zadanie2.Calculator();
             double test = p.Division(9000, 1000);
             Assert.AreEqual(9, test);

         }
         [Test]
        public void TestMinus()
        {
            var p = new zadanie2.Calculator();
            double test = p.Minus(5, 3);
            Assert.AreEqual(2, test);

        }
         [Test]
         public void TestMinus2()
         {
             var p = new zadanie2.Calculator();
             double test = p.Minus(100, 50);
             Assert.AreEqual(50, test);

         }
         [Test]
         public void TestMinus3()
         {
             var p = new zadanie2.Calculator();
             double test = p.Minus(20, 50);
             Assert.AreEqual(-30, test);

         }
         [Test]
         public void TestMultiply()
         {
             var p = new zadanie2.Calculator();
             double test = p.Multiply(20, 50);
             Assert.AreEqual(1000, test);

         }
         [Test]
         public void TestMultiply2()
         {
             var p = new zadanie2.Calculator();
             double test = p.Multiply(-10, 50);
             Assert.AreEqual(-500, test);

         }
         [Test]
         public void TestMultiply3()
         {
             var p = new zadanie2.Calculator();
             double test = p.Multiply(10, 10);
             Assert.AreEqual(100, test);

         } 
                     
    }
}
