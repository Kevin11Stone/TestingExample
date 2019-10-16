using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingExample.Models.Tests
{
    [TestClass()]
    public class StringHelperTests
    {
        [TestMethod()]
        [DataRow("joe.txt")]
        [DataRow("joe.TXT")]
        [DataRow("  october2019.txt")]
        [DataRow("joe.txt   ")]
        [DataRow("   joe.txt   ")]
        public void IsTextFile_ValidFileName_ReturnsTrue(string fileName)
        {

            // act
            bool result = StringHelper.IsTextFile(fileName);

            // assert
            Assert.IsTrue(result);

        }


        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow(".text")]
        [DataRow("hello world")]
        [DataRow(".txt")]
        [DataRow("   .txt")]
        public void IsTextFile_InvalidFileName_ReturnsFalse(string fileName)
        {
            bool result = StringHelper.IsTextFile(fileName);

            Assert.IsFalse(result);
        }



    }
}