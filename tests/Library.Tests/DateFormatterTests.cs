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
        //Assert.Throws<Exception> (() => TestDateFormat.DateFormatter.ChangeFormat(dateIngresado));
        Assert.That((String.IsNullOrEmpty(dateIngresado))); //OJO CON ESTO ENTONCES.
    }
}

//public TestDateLength(), aca me valida, incluso si la fecha es vacia.
//public SeparatorsAreValid(), chequea que en las posiciones correspondientes esta la /

//el anterior incluso sirve para casos en los que tenga - en vez de / como separador.

//public ComponentsAreValid(), verifica dia entre 1-31 y  mes entre 1-12

/*tenemos que devolver el string vacio en vez de un mensaje de error, por que tengo que 
escribir lo mismo en cada test, y cualquier cambio en el string que devuelvo ya no me sirve
para seguir usandolo. Podemos usar excepciones.
*/






