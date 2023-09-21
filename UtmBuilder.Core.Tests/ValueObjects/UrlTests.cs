namespace UtmBuilder.Core.Tests;

[TestClass]
public class UrlTest
{
    public const string InvalidUrl = "Banana";
    public const string ValidUrl = "https://balta.io";


    [TestMethod("Deve retornar uma exceção quando a url for inválida")]
    [TestCategory("Teste de URL")]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        new Url(InvalidUrl);
    }

    [TestMethod("Não deve retornar uma exceção quando a url for válida")]
    [TestCategory("Teste de URL")]
    public void ShouldNotReturnExceptionWhenUrlIsvalid()
    {
        new Url(ValidUrl);
        Assert.IsTrue(true);
    }

    [TestMethod]
    [DataRow(" ", true)]
    [DataRow("http", true)]
    [DataRow("banana", true)]
    [DataRow("https://balta.io", false)]
    public void TestResultUrl(string link, bool expectException)
    {
        if (expectException)
        {
            try
            {
                new Url(link);
                Assert.Fail("");
            }
            catch (InvalidUrlException e)
            {
                Assert.IsTrue(true);

            }
        }
        else
        {
            new Url(link);
        }
    }
}