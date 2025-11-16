public class AuthService
{
    private string? _currentUser;

    public bool IsLoggedIn => !string.IsNullOrEmpty(_currentUser);

    public string? CurrentUser => _currentUser;

    public bool Login(string username, string password)
    {
        if(username == "admin" && password == "password")
        {
            _currentUser = username;
            return true;
        }

        return false;
    }

    public void Logout()
    {
        _currentUser = null;
    }
}
