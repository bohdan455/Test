namespace MathLibrary.Tests.Unit;

public class UnitTest1
{
    [Fact]
    public void Calculator_Sum_CorrectResult()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Sum(1, 2);

        // Assert
        Assert.Equal(3, result);
    }
}