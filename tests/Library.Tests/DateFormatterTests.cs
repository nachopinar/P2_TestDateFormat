namespace Library.Tests;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DateTests()
    {
        const string dateIngresado = "06/09/2023";
        const string dateExpected = "2023-06-09";
        const string dateFormateada = DataFormatterTests.ChangeFormat(date);
        Assert.AreEqual(dateFormateada, dateExpected);
    }
}







