using Microsoft.UI.Xaml.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.AppContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using Tyuiu.VitovskayaAN.Sprint0.Task4.V0.Lib;
namespace Tyuiu.VitovskayaAN.Sprint0.Task4.V0.Test
{
    [TestClass]
    public partial class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSubstactionValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
