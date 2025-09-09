using Microsoft.UI.Xaml.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.AppContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using Tyuiu.VitovskayaAN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.VitovskayaAN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алёна";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Алёна", res);
        }

       
    }
}
