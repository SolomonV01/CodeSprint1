using SprintFinal;
namespace SprintTest;

[TestClass]
public class UnitTest1
{
    private Colors colorsInstance;

    [TestInitialize]
    public void Setup()
    {
        colorsInstance = new Colors();
    }

    [TestMethod]
    public void ChooseColor_RedInput_PrintCorrectInfo()
    {
        // Arrange
        string input = "1";
        var expectedOutput = "You choseRed\nA color with a frequency between 480-510 terahertz";

        // Act
        using (var consoleOutput = new StringWriter())
        {
            Console.SetOut(consoleOutput);
            Console.SetIn(new StringReader(input));
            colorsInstance.ChooseColor();
            var actualOutput = consoleOutput.ToString().Trim();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }

    [TestMethod]
    public void ChooseColor_CyanInput_PrintCorrectInfo()
    {
        // Arrange
        string input = "5";
        var expectedOutput = "You choseCyan\nA color with a frequency between 600-620 terahertz";

        // Act
        using (var consoleOutput = new StringWriter())
        {
            Console.SetOut(consoleOutput);
            Console.SetIn(new StringReader(input));
            colorsInstance.ChooseColor();
            var actualOutput = consoleOutput.ToString().Trim();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }

    [TestCleanup]
    public void Cleanup()
    {
        colorsInstance = null;
    }
}
