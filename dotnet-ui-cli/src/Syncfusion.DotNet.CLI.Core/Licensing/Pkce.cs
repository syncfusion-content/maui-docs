using System.Security.Cryptography;
using System.Text;

namespace Syncfusion.DotNet.CLI.Core.Licensing;

/// <summary>RFC 7636 PKCE helpers (S256).</summary>
public static class Pkce
{
    public static string GenerateVerifier() => Base64Url(RandomNumberGenerator.GetBytes(48));

    public static string ChallengeFromVerifier(string verifier) => Base64Url(SHA256.HashData(Encoding.ASCII.GetBytes(verifier)));

    public static string RandomState() => Base64Url(RandomNumberGenerator.GetBytes(24));

    private static string Base64Url(byte[] bytes) => Convert.ToBase64String(bytes).TrimEnd('=').Replace('+', '-').Replace('/', '_');
}
