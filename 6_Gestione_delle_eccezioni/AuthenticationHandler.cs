public class AuthenticationHandler
{
    private readonly Dictionary<Type, Action> exceptionActions;

    public AuthenticationHandler()
    {
        // IF WE WANT THE CODE TO BE MORE DYNAMIC WE CAN ADD EXCEPTION NAMES TO MANAGE CASES WHERE THE NAME CHANGES -> BUT WE NEED TO CARE FOR SQL INJECTIONS
        this.exceptionActions = new Dictionary<Type, Action> 
        {
            { typeof(InvalidUsernameException), () => {/*I CAN ADD HERE CUSTOM EXCPETIONS DATA FROM DB FOR EXAMPLE*/}},
            { typeof(InvalidPasswordException), () => {}}
        };
    }

    public void Handle(AuthService authService, string username, string password)
    {
        try
        {
            authService.Authenticate(username, password);
            Console.WriteLine("Authentication successful.");
        }
        catch (AuthenticationException ex)
        {
            Action? action;
            if (exceptionActions.TryGetValue(ex.GetType(), out action))
            {
                action?.Invoke(); // call the action, for this case will be called the generic one set in the constructor of its exception
            }
            Console.WriteLine($"Authentication failed: {ex.Message}");  // This will use the message from the exception
        }
    }
}