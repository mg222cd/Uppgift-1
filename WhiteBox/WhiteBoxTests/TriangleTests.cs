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
        //TEST FÖR DATATYP & TEST FÖR ANTAL INMATADE VÄRDEN???

        //TEST ATT VÄRDENA ÄR RIMLIGA
        //FÅR EJ VARA NOLL ELLER NEGATIVA TAL
        [TestMethod()]
        public void isNotValidNumbers()
        {
            Triangle triangel1 = new Triangle(0, 0, 0);
            Assert.IsFalse(triangel1.isIsosceles());

            Triangle triangel2 = new Triangle(0, 0, 0);
            Assert.IsFalse(triangel2.isEquilateral());

            Triangle triangel3 = new Triangle(0, 0, 0);
            Assert.IsFalse(triangel3.isScalene());
        }

        //TEST FÖR POSITIVA TAL UNDER 1
        //SÅ ATT DE INTE AVRUNDAS TILL 1

        //MATEMATISKT FINLIR
        //TEST ATT VÄRDENA ÄR RIMLIGA FÖR EN TRIANGEL

        //TEST AV RIMLIGA VÄRDEN SÅ ATT DE FUNGERAR
        //PÅ DE 3 TYPERNA AV TRIANGLAR
        [TestMethod()]
        public void isScaleneTest()
        {
            
            
        }
        


    }
}
