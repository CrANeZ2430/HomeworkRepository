namespace Homework12Test;

public class UnitTest1
{
    [Fact]
    public void CalculateFibonacciNumber_CheckCommonValue()
    {
        // Arrange
        const int orderNumber = 11;
        const long expectedResult = 55;
        
        //Act
        long fibonacciNumber = AdditionalMath.CalculateFibonacciNumber(orderNumber);

        //Assert
        Assert.True(fibonacciNumber == expectedResult);
    }
    
    [Fact]
    public void CalculateFibonacciNumber_CheckNegativeValue()
    {
        // Arrange
        const int orderNumber = -10;
        const long expectedResult = -1;
        
        //Act
        long fibonacciNumber = AdditionalMath.CalculateFibonacciNumber(orderNumber);

        //Assert
        Assert.True(fibonacciNumber == expectedResult);
    }
    
    [Fact]
    public void CalculateFibonacciNumber_CheckSpecialValues()
    {
        // Arrange
        const int orderNumber1 = 1;
        const long expectedResult1 = 0;
        
        const int orderNumber2 = 2;
        const long expectedResult2 = 1;
        
        //Act
        long fibonacciNumber = AdditionalMath.CalculateFibonacciNumber(orderNumber1);

        //Assert
        Assert.True(fibonacciNumber == expectedResult1);
        
        //Act
        fibonacciNumber = AdditionalMath.CalculateFibonacciNumber(orderNumber2);

        //Assert
        Assert.True(fibonacciNumber == expectedResult2);
    }
}