using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

    [TestClass()]
    public class TriangleTests
    {

        //Test av värden...
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void isExceptionWithZero()
        {
            Triangle unvalidTriangle = new Triangle(0, 0, 0); //...får ej vara noll

        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void isExceptionWithMinus()
        {
            Triangle unvalidTriangle = new Triangle(-1.0, -2.0, -3.0); //...får ej vara negativa
        }
        
        //Om värdet är positivt men < 1 ska det inte avrundas till liksidig triangel
        [TestMethod()]
        public void isNotEquilateralWithZero()
        {
            Triangle notEquilateralTriangle = new Triangle(0.2, 0.2, 0.4);
            Assert.IsFalse(notEquilateralTriangle.isEquilateral());
        }

        //test av Scalene/oliksidig med nolldecimaler
        [TestMethod()]
        public void isScaleneWithZero()
        {
            Triangle triangle = new Triangle(-0.2, -0.5, 0.3);
            Assert.IsTrue(triangle.isScalene());
        }

        //test av Isosceles/likbent med nolldecimaler
        [TestMethod()]
        public void isIsoscelesWithZero()
        {
            Triangle triangle = new Triangle(-0.2, -0.5, 0.2);
            Assert.IsTrue(triangle.isScalene());
        }

        //test av Equilateral/liksidig med nolldeciamler
        [TestMethod()]
        public void isEquilateralWithZero()
        {
            Triangle triangle = new Triangle(-0.9, -0.9, 0.9);
            Assert.IsTrue(triangle.isEquilateral());
        }

        //test att enbart 1 st blir svaret, i 3 kombinationer
        [TestMethod()]
        public void isEquilateralOnly()
        {
            Triangle triangle = new Triangle(9, 9, 9);
            Assert.IsTrue(triangle.isEquilateral());
            Assert.IsFalse(triangle.isIsosceles());
            Assert.IsFalse(triangle.isScalene());
        }
        [TestMethod()]
        public void isIsoscelesOnly()
        {
            Triangle triangle = new Triangle(15, 15, 10);
            Assert.IsFalse(triangle.isEquilateral());
            Assert.IsTrue(triangle.isIsosceles());
            Assert.IsFalse(triangle.isScalene());
        }
        [TestMethod()]
        public void isScaleneOnly()
        {
            Triangle triangle = new Triangle(30, 30, 30);
            Assert.IsFalse(triangle.isEquilateral());
            Assert.IsFalse(triangle.isIsosceles());
            Assert.IsTrue(triangle.isScalene());
        }

        //Test av isScalene/oliksidig
        //...med rätta värden
        [TestMethod()]
        public void isScaleneTrue()
        {
            Triangle triangle = new Triangle(10, 30, 22);
            Assert.IsTrue(triangle.isScalene());
        }
        //...med felaktiga värden
        [TestMethod()]
        public void isScaleneFalse()
        {
            Triangle triangle = new Triangle(10, 10, 22);
            Assert.IsFalse(triangle.isScalene());
        }

        //Test av isEquilateral
        //...med rätta värden
        [TestMethod()]
        public void isEquilateralTrue()
        {
            Triangle triangle = new Triangle(9, 9, 9);
            Assert.IsTrue(triangle.isEquilateral());
        }
        //...med felaktiva värden
        [TestMethod()]
        public void isEquilateralFalse()
        {
            Triangle triangle = new Triangle(9, 19, 29);
            Assert.IsFalse(triangle.isEquilateral());
        }

        //Test av isIsosceles/likbent
        //... med rätta värden
        [TestMethod()]
        public void isIsoscelesTrue()
        {
            Triangle triangle = new Triangle(25, 25, 100);
            Assert.IsTrue(triangle.isIsosceles());
        }
        //... med felaktiga värden
        [TestMethod()]
        public void isIsoscelesFalse()
        {
            Triangle triangle = new Triangle(25, 250, 100);
            Assert.IsFalse(triangle.isIsosceles());
        }

        //Test av Point
        [TestMethod()]
        public void isPoint()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);
            Point c = new Point(3, 3);

            Triangle drawTriangle = new Triangle(a, b, c);
        }
        //...med undantag, bara 0-värden
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void isPointWithException()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 0);
            Point c = new Point(0, 0);

            Triangle drawTriangle = new Triangle(a, b, c);
        }
        //...med undantag, 2 identiska värden
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void isPointWithExceptionTwoEqual()
        {
            Point a = new Point(12, 0);
            Point b = new Point(12, 0);
            Point c = new Point(1, 2);

            Triangle drawTriangle = new Triangle(a, b, c);
        }
        //...med undantag, för få värden
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void isPointWithExceptionTooFew()
        {
            Point a = new Point(12, 5);
            Point b = new Point(50, 4);

            Triangle drawTriangle = new Triangle(new Point[] {a, b});
        }
        //...med undantag, för många värden
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void isPointWithExceptionTooMany()
        {
            Point a = new Point(12, 5);
            Point b = new Point(50, 4);
            Point c = new Point(23, 7);
            Point d = new Point(1, 5);

            Triangle drawTriangle = new Triangle(new Point[] { a, b, c, d });
        }


    }
}
