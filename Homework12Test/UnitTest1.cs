namespace Homework12Test;

public class UnitTest1
{
    [Fact]
    public void CalculateFibonacciNumber_CheckCommonValue()
    {
        // Assert
        const int orderNumber = 11;
        const long expectedResult = 55;
        
        //Arrange

        long fibonacciNumber = AdditionalMath.CalculateFibonacciNumber(orderNumber);

        //Act

        Assert.True(fibonacciNumber == expectedResult);
    }
    
    [Fact]
    public void CalculateFibonacciNumber_CheckNegativeValue()
    {
        // Assert
        const int orderNumber = -10;
        const long expectedResult = -1;
        
        //Arrange
        long fibonacciNumber = AdditionalMath.CalculateFibonacciNumber(orderNumber);

        //Act
        Assert.True(fibonacciNumber == expectedResult);
    }
    
    [Fact]
    public void CalculateFibonacciNumber_CheckSpecialValues()
    {
        // Assert
        const int orderNumber1 = 1;
        const long expectedResult1 = 0;
        
        const int orderNumber2 = 2;
        const long expectedResult2 = 1;
        
        //Arrange
        long fibonacciNumber = AdditionalMath.CalculateFibonacciNumber(orderNumber1);

        //Act
        Assert.True(fibonacciNumber == expectedResult1);
        
        //Arrange
        fibonacciNumber = AdditionalMath.CalculateFibonacciNumber(orderNumber2);

        //Act
        Assert.True(fibonacciNumber == expectedResult2);
    }
}