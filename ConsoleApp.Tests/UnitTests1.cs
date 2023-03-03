using ConsoleAppProject.App01;

namespace UnitTestProject
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();


            converter.FromUnit = DistanceConverter.ToString;
            converter.ToUnit = DistanceConverter.ToString;

            converter.FromDistance = 1.0;
            converter.ConvertDistance();

            double expectedDistance = 5280;
            double actual = converter.ToDistance;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
              
            
        }
    }
}