using System.Security.Cryptography;
using System.Text;

namespace Njm.Core.Cryptography;

public static class EncryptionService
{
    public static string ComputeSha256(string input)
    {
        using var sha = SHA256.Create();
        var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
        return Convert.ToBase64String(bytes);
    }
}
