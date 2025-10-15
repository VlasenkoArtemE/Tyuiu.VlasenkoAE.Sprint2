using Tyuiu.VlasenkoAE.Sprint2.Task4.V13.Lib;

namespace Tyuiu.VlasenkoAE.Sprint2.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 20;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 11;
            double res = ds.Calculate(x, y);
            double wait = 0.100;
            Assert.AreEqual(wait, res);
        }
    }
}
