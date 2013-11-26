using Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace QuestionTest
{
    
    
    /// <summary>
    ///Это класс теста для TestDataTest, в котором должны
    ///находиться все модульные тесты TestDataTest
    ///</summary>
    [TestClass()]
    public class TestDataTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
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
        }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Тест для Glav
        ///</summary>
        [TestMethod()]
        public void GlavTest()
        {
            Question target = new Question();
            string pct = "picture"; 
            int glv = 1; 
            int nmbr = 1;
            string que = "Question";
            int right = 0; 
            List<string> str = new List<string>(); 
            str.Add("answer");
            target.question(pct, glv, nmbr, que, right, str);
            LoadTestFromFile.Questions.Add(target);
            int expected = 1; // TODO: инициализация подходящего значения
            int actual;
            actual = TestData.Glav();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для SwitchPicture
        ///</summary>
        [TestMethod()]
        public void SwitchPictureTest()
        {
            Question target = new Question();
            string pct = "picture";
            int glv = 1;
            int nmbr = 1;
            string que = "Question";
            int right = 0;
            List<string> str = new List<string>();
            str.Add("answer");
            target.question(pct, glv, nmbr, que, right, str);
            LoadTestFromFile.Path = "g";
            string expected = "g\\picture"; // TODO: инициализация подходящего значения
            string actual;
            actual = TestData.SwitchPicture(target);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для Result
        ///</summary>
        [TestMethod()]
        public void ResultTest()
        {
            Question target = new Question();
            string pct = "picture";
            int glv = 1;
            int nmbr = 1;
            string que = "Question";
            int right = 0;
            List<string> str = new List<string>();
            str.Add("answer");
            target.question(pct, glv, nmbr, que, right, str);
            Test.VoprosiTesta.Add(target);
            Test.ChosenAnswers.Add(0);
            string expected = "100"; // TODO: инициализация подходящего значения
            string actual;
            actual = TestData.Result();
            Assert.AreEqual(expected, actual);
        }
    }
}
