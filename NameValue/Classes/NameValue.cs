// Name Value test program
// Zaid Rashid
// 8/7/2014
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameValuePairTestProgram.Classes
{
    class NameValue : IDisposable
    {
        public void Dispose()
        {
 
        }

        public KeyValuePair<string, string> ConvertToKeyValuePair(string nameValue)
        {
            int index = nameValue.IndexOf('=');
            if (index > 0)
            {
                string key = (nameValue.Substring(0, index)).Trim();
                string value = (nameValue.Substring((index + 1), nameValue.Length - (index + 1))).Trim();

                if (IsAlphaNumeric(key) && IsAlphaNumeric(value))
                {
                    return new KeyValuePair<string, string>(key, value);
                }
            }
            
            return new KeyValuePair<string, string>();
        }

        public string ConvertToReadableString(KeyValuePair<string, string> nameValuePair)
        {
            if (!nameValuePair.Equals(new KeyValuePair<string, string>()))
            {
                return string.Format("{0}={1}", nameValuePair.Key.ToString(), nameValuePair.Value.ToString());
            }
            else
            {
                return string.Empty;
            }
        }

        private bool IsAlphaNumeric(string value)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

    }
}
