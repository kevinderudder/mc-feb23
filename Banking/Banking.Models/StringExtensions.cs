using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
    public static class StringExtensions
    {
        public static string ToJason(this string o, string name) {
            return $"{{name:'{name}'}}"; // {name:'glenn'}
        }

        public static string Encrypt(this BankAccount b, string encrypt, string salt) {
            return null;
        }
    }
}
