using Tyuiu.VlasenkoAE.Sprint2.Task2.V23.Lib;

namespace Tyuiu.VlasenkoAE.Sprint2.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 3;
            int y = 5;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
