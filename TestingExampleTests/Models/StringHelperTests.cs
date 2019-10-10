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
        public void IsTextFile_ValidTextFile_ReturnsTrue()
        {
            // arrange
            string fileName = "joe.txt";

            // act
            bool result = StringHelper.IsTextFile(fileName);

            // assert
            Assert.IsTrue(result);

        }
    }
}