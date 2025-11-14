using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminINF042025Czerwiec2Grupa
{
    internal class CaesarsCipher
    {
        private int key;
        private string inputMsg;
        public string result;
        public CaesarsCipher(int key, string inputMsg)
        {
            this.key = key;
            this.inputMsg = inputMsg;
            Encrypt();
        }
        private void Encrypt()
        {
            List<char> encryptedMsg = new List<char>();

            foreach (char c in inputMsg)
            {
                if (c >= 'a' && c <= 'z')
                {
                    if (c + key <= 'z' && c + key >= 'a')
                    {
                        encryptedMsg.Add((char)(c + key));
                    }
                    else if (c + key > 'z')
                    {
                        encryptedMsg.Add((char)('a' + (c + key - 'z' - 1)));
                    }
                    else if (c + key < 'a')
                    {
                        encryptedMsg.Add((char)('z' - ('a' - (c + key) - 1)));
                    }
                }
                else
                {
                    encryptedMsg.Add(c);
                }
            }

            this.result = string.Join("", encryptedMsg);
        }
        public string SchowResult()
        {
            return result;
        }
    }
}
