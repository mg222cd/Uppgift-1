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
        private TestContext testContextInstance;

        //Gets or Sets the test context which provides
        //information about and functionality for the current test run
        public TestContext TestContext
        {
            get 
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }

            //TEST FÖR DATATYP
            //ENDAST DOUBLE SKA GODTAS

            //TEST FÖR ANTAL INMATADE VÄRDEN
            //ENDAST 3 ST SKA GODTAS

            //TEST ATT VÄRDENA ÄR RIMLIGA
            //FÅR EJ VARA NOLL ELLER NEGATIVA TAL

            //TEST FÖR POSITIVA TAL UNDER 1
            //SÅ ATT DE INTE AVRUNDAS TILL 1

            //MATEMATISKT FINLIR
            //TEST ATT VÄRDENA ÄR RIMLIGA FÖR EN TRIANGEL

            //TEST AV RIMLIGA VÄRDEN SÅ ATT DE FUNGERAR
            //PÅ DE 3 TYPERNA AV TRIANGLAR

        }

        


    }
}
