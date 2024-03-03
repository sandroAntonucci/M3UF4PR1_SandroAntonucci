using CRAM;

namespace TestProjectCRAM
{
    [TestClass]
    public class UnitTestCheckValidAction
    {
        [TestMethod]
        public void CheckValidAction_ValidAction_ReturnsTrue()
        {
            // Arrange
            int action = 1;

            // Act
            bool result = Program.CheckValidAction(action);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckValidAction_InvalidAction_ReturnsFalse()
        {
            // Arrange
            int action = 3;

            // Act
            bool result = Program.CheckValidAction(action);

            // Assert
            Assert.IsFalse(result);
        }
    }

    [TestClass]

    public class UnitTestGenerateRandom
    {
        [TestMethod]
        public void GenerateRandom_ValidRange_ReturnsValueBetweenMinAndMax()
        {
            // Arrange
            int min = 1;
            int max = 3;

            // Act
            int result = Program.GenerateRandom(min, max);

            // Assert
            Assert.IsTrue(result >= min && result <= max);
        }
    }

    [TestClass]

    public class UnitTestGenerateRandomAnimal
    {
        [TestMethod]
        public void GenerateRandomAnimal_ValidAnimal_ReturnsAnimal()
        {
            // Arrange
            AAnimal animalToRescue;

            // Act
            animalToRescue = Program.GenerateRandomAnimal();

            // Assert
            Assert.IsNotNull(animalToRescue);
        }
    }
}