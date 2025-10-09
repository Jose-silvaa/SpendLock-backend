using DevOne.Security.Cryptography.BCrypt;

namespace spendlock_backend.Helpers;

public class PasswordHelper
{
    
    public static string HashPassword(string password) =>
        BCryptHelper.HashPassword(password, BCryptHelper.GenerateSalt());

    public static bool VerifyPassword(string password, string hash) =>
        BCryptHelper.CheckPassword(password, hash);
}