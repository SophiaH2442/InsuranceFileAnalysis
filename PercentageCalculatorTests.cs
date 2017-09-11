using NUnit.Framework;

namespace InsuranceFileAnalysis.Tests
{
    [TestFixture]
    public class PercentageCalculatorTests
    {

        [Test]
        public void GetReinforcedConcreteCommercialProperties_ReturnsCorrectResult()
        {
            //First Step: "Arrange" Setup Test Data
            var filePath = TestContext.CurrentContext.TestDirectory + @"\TestData\test_FL_insurance_sample.csv";

            // Second Step: "Act" Execute Code
            var percentage = PercentageCalculator.GetReinforcedConcreteCommercialProperties(filePath);

            // Third Step: "Assert" Verify Assertion
            var expectedPercentage = 0.5;
            Assert.AreEqual(expectedPercentage, percentage);
        }

    }
}
