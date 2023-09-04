public class AuthService
{
    public void Authenticate(string username, string password)
    {
        // fake conditions
        if (username != "admin")
        {
            throw new InvalidUsernameException();
        }

        if (password != "password")
        {
            throw new InvalidPasswordException();
        }
        
    }
}