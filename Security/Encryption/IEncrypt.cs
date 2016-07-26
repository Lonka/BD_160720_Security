using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Security.Encryption
{
    interface IEncrypt
    {
        string GetSecurePassword(string password);

        string GetSecurePassword(string password, string salt);
    }
}
