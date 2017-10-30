using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extent3_test
{

    public abstract class ExemploNunit
    {
        protected ExtentReports _extent;
        protected ExtentTest _test;
        protected ExtentXReporter _extentX;


        [OneTimeSetUp]
        protected void Setup()
        {
            //Diretório que salva o relatório (html)
            var dir = TestContext.CurrentContext.TestDirectory + "\\";
            var fileName = this.GetType().ToString() + ".html";
            var htmlReporter = new ExtentHtmlReporter(dir + fileName);

            _extent = new ExtentReports();  
            //Método para gravar informações no relatório local   
            _extent.AttachReporter(htmlReporter);

            //Parte ExtentX
            _extentX = new ExtentXReporter("mongodb://localhost:27017");
            _extentX.Configuration().ServerURL = "http://localhost:27017/";
            _extentX.Configuration().ProjectName = ("Test - 2");
            _extentX.Configuration().ReportName = ("extent3_test.ExemplosNUnit.TestNUnit.html");

            //linha responsável por gravar no extentX
            _extent.AttachReporter(_extentX);


            //http://localhost:1337/#/
        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            _extent.Flush();
        }

      

        [SetUp]
        public void BeforeTest()
        {
            _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                ? ""
                : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }

            _test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            _extent.Flush();
        }
    }
}
