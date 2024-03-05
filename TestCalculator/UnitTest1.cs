namespace TestCalculator;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
       int expected = 24;
       int actual = Calculator.Add(5,7);
       Assert.AreEqual(expected,actual,"Equal?");
    }
}