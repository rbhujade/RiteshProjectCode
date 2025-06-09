namespace ConsoleApp1
{
    class Program
    {

    }

    public static void Code()
    {
        var userName = CognitoAccessToken.FromAccessToken(accessToken.ToString())?.GetUserName() ?? default;
        if (userName == default)
            return BadRequest(new ApiBadRequestResponse("Invalid access token."));

        using var dataConnection = AppDataConnection.CreateDataConnection(_appSettings.ConnectionStrings.MainDb);
        var email = dataConnection.Dbo.Users.Where(x => x.Id.ToString() == userName && x.UserStatusId != UserStatuses.Disabled).Select(y => y.Email).FirstOrDefault() ?? default;
        if (email == default)
            return BadRequest(new ApiBadRequestResponse("Invalid User."));


        ////
        ///replace above with below


        var email = string.Empty;
        var userName = CognitoAccessToken.FromAccessToken(accessToken.ToString())?.GetUserName() ?? default;
        if (userName == default)
            return BadRequest(new ApiBadRequestResponse("Invalid access token."));
        using var dataConnection = AppDataConnection.CreateDataConnection(_appSettings.ConnectionStrings.MainDb);
        if (Guid.TryParse(userName, out _))
        {
            email = dataConnection.Dbo.Users.Where(x => x.Id.ToString() == userName && x.UserStatusId != UserStatuses.Disabled).Select(y => y.Email).FirstOrDefault() ?? default;
            if (email == default && email != string.Empty)
                return BadRequest(new ApiBadRequestResponse("Invalid User."));
        }
        else
        {
            email = userName.Substring(userName.IndexOf("_") + 1);
            userName = dataConnection.Dbo.Users.Where(x => x.Email == email && x.UserStatusId != UserStatuses.Disabled).Select(y => y.Id.ToString()).FirstOrDefault() ?? default;
        }
    }
}

