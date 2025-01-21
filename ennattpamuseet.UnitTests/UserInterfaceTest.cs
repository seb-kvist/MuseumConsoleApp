using System;
using System.Net.NetworkInformation;
namespace ennattpamuseet.UnitTests;


public class UserInterfaceTest
{
    [Fact]
    public void IsUserInputValidTest()
    {
        // Given
        UserInterface ui = new UserInterface();

        // When
        int userChoice = 1;
        ui.IsUserInputValid("2",out userChoice);

        // Then
        Assert.Equal(2,userChoice);
    }
}
