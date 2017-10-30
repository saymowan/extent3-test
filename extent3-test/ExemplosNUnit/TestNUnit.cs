using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extent3_test.ExemplosNUnit
{
    public class TestNUnit :ExemploNunit
    {

        [Test]
        public void testNunit()
        {
            _test.Pass("Teste passou man");
            Assert.AreEqual("X", "Y");
        }

        [Test]
        public void testNunit2()
        {
            _test.Pass("Teste passou man");
            Assert.AreEqual("X", "X");
        }


    }//fim class
}//fim namespace
