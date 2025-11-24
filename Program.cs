using System.Security.Cryptography;
using System.Text;

var bytes = new byte[64];
using (var rng = RandomNumberGenerator.Create())
{
    rng.GetBytes(bytes);
}
var key = Convert.ToBase64String(bytes);
Console.WriteLine(key);



