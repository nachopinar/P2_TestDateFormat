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

    [Test]

    public void FechaIncorrecta()
    {
        const string dateIngresado = "21052002";
        const string dateExpected = "2002-05-21";
        string dateCambiado = TestDateFormat.DateFormatter.ChangeFormat(dateIngresado);
        Assert.AreNotEqual(dateCambiado, dateExpected);
    }

    [Test]

    public void FechaVacia()
    {
        const string dateIngresado = "";
        //const string dateExpected = "no esto";
        //Assert.Throws<Exception> (() => TestDateFormat.DateFormatter.ChangeFormat(dateIngresado));
        //aca lo corro y veo que exception me tira 
        Assert.Throws<ArgumentOutOfRangeException> (() => TestDateFormat.DateFormatter.ChangeFormat(dateIngresado));
    }
}







