using ConsoleAppProject.App01;

using ConsoleAppProject.App01;

namespace UnitTestProject
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMIlesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles.ToString();
            converter.ToUnit = DistanceUnits.Feet.ToString();

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expected = 5280;
            double actual = converter.ToDistance;

            Assert.AreEqual(expected, actual);
        }
    }
}