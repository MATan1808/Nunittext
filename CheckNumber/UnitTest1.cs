using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PrimeNumber;
using System.IO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
namespace CheckNumber
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod] // test case number=2, kq=1
        public void TestPrimeNumber1()
        {
            int expectted , actual, number;
            number = 1;
            PrimeChecker c = new PrimeChecker(number);
            expectted = 0;
            actual = c.IsPrime(number);
            Assert.AreEqual(expectted, actual); //so sánh kq thực tế và kế quả mong đợi
        }
        [TestMethod] // test case number=2, kq=1
        public void TestPrimeNumber2()
        {
            int expectted, actual, number;
            number = 2;
            PrimeChecker c = new PrimeChecker(number);
            expectted = 1;
            actual = c.IsPrime(number);
            Assert.AreEqual(expectted, actual); //so sánh kq thực tế và kế quả mong đợi
        }

        // kiem tra Nam Nhuan 
        [TestMethod] // test case number=2024, kq=1
        public void TestLeapYear1()
        {
            int expectted, actual, number;
            number = 2024;
            IsLeapYear c = new IsLeapYear(number);
            expectted = 1;
            actual = c.LeapYear(number);
            Assert.AreEqual(expectted, actual); //so sánh kq thực tế và kế quả mong đợi
        }

        // kiem tra Nam Nhuan 
        [TestMethod] // test case number=2024, kq=1
        public void TestLeapYear2()
        {
            int expectted, actual, number;
            number = 2026;
            IsLeapYear c = new IsLeapYear(number);
            expectted = 1;
            actual = c.LeapYear(number);
            Assert.AreEqual(expectted, actual); //so sánh kq thực tế và kế quả mong đợi
        }
        public TestContext TestContext { get; set; }

        //lien ket kiem tra TestDataPrime.csv
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                  @"|DataDirectory|\DATA\TestDataPrime.csv", "TestDataPrime#csv", DataAccessMethod.Sequential)]
        public void TestPrimeNumbersFromCSV()
        {
            int number = Convert.ToInt32(TestContext.DataRow["a"]);
            int expected = Convert.ToInt32(TestContext.DataRow["expected"]);

            PrimeChecker c = new PrimeChecker(number);
            int actual = c.IsPrime(number);

            Assert.AreEqual(expected, actual); // so sánh kq thực tế và kế quả mong đợi
        }

        

        //lien ket kiem tra TestDataLeapNumber.csv
        // kiểm tra năm nhuận từ file CSV
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                  @"|DataDirectory|\Data\TestDataLeapNumber.csv", "TestDataLeapNumber#csv", DataAccessMethod.Sequential)]
        public void TestDataLeapNumber()
        {
            int year = Convert.ToInt32(TestContext.DataRow["year"]);
            int expected = Convert.ToInt32(TestContext.DataRow["expected"]);

            IsLeapYear c = new IsLeapYear(year);
            int actual = c.LeapYear(year);

            Assert.AreEqual(expected, actual); // so sánh kq thực tế và kết quả mong đợi
        }


    }
}
