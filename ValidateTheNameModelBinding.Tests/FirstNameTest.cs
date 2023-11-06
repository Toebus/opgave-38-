using ValidateTheNameModelBinding.Models;

namespace ValidateTheNameModelBinding.Tests;

public class FirstNameTest{

    [Theory]
    [InlineData("test")]
    public void ValidateFirstNameLengthNoException(string name)
    {
        var exception = Record.Exception
        (
            ()=> new FirstName(name)
        );
        Assert.Null(exception);
    }
}