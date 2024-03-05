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


        [TestMethod]
    public void TestMethod2()
    {
       int expected = 6;
       int actual = Calculator.Subtract(7,4);
       Assert.AreEqual(expected,actual,"Equal?");
    }
}