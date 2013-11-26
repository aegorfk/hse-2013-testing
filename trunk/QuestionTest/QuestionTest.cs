using Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace QuestionTest
{
    
    
    /// <summary>
    ///Это класс теста для QuestionTest, в котором должны
    ///находиться все модульные тесты QuestionTest
    ///</summary>
    [TestClass()]
    public class QuestionTest
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
        ///Тест для question
        ///</summary>
        [TestMethod()]
        public void questionTest()
        {
            Question target = new Question(); // TODO: инициализация подходящего значения
            string pct = "picture"; // TODO: инициализация подходящего значения
            int glv = 1; // TODO: инициализация подходящего значения
            int nmbr = 1; // TODO: инициализация подходящего значения
            string que = "Question"; // TODO: инициализация подходящего значения
            int right = 0; // TODO: инициализация подходящего значения
            List<string> str = new List<string>(); // TODO: инициализация подходящего значения
            str.Add("answer");
            target.question(pct, glv, nmbr, que, right, str);
            Assert.AreEqual(pct, target.Pict);
        }

        /// <summary>
        ///Тест для Rightanswer
        ///</summary>
        [TestMethod()]
        public void RightanswerTest()
        {
            Question target = new Question(); // TODO: инициализация подходящего значения
            int expected = 0; // TODO: инициализация подходящего значения
            int actual;
            target.Rightanswer = expected;
            actual = target.Rightanswer;
            Assert.AreEqual(expected, actual);
        }
    }
}
