using Tyuiu.VitovskayaAN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.VitovskayaAN.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        public void CheckGetMessageValid()
        {

            var name = "����";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("������, A���", res);
        }
    }
}