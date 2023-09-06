namespace Library.Tests;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FechaCorrecta()
    {
        const string dateIngresado = "06/09/2023";
        const string dateExpected = "2023-09-06";
        string dateFormateada = TestDateFormat.DateFormatter.ChangeFormat(dateIngresado);
        Assert.AreEqual(dateFormateada, dateExpected);
    }
}







