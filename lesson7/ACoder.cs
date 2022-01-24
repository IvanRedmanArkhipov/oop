using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class ACoder : ICoder
    {
        public string Encode(string shifr)
        {
            char[] chars = shifr.ToCharArray();
            // дешифрование (понятия не имею как сделать)
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    switch (chars[i])
                    {
                        case 'z': chars[i] = 'a'; break;
                        case 'Z': chars[i] = 'A'; break;
                        default: chars[i] = (char)(chars[i] + 1); break;
                    }
                }
            }
            shifr = String.Join("", chars);
            return shifr;
        }
        public string Decode(string shifr)
        {
            char[] chars = shifr.ToCharArray();
            // дешифрование (понятия не имею как сделать)
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    switch (chars[i])
                    {
                        case 'z': chars[i] = 'a'; break;
                        case 'Z': chars[i] = 'A'; break;
                        default: chars[i] = (char)(chars[i] - 1); break;
                    }
                }
            }
            shifr = String.Join("", chars);
            return shifr;
        }
    }
}
