using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portable_Password_Generator
{
    public class CharacterPool
    {
        public string exNone = "!\"#$%&'()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[\\]^_`{|}~"; // all characters
        public string exNumbers = "!\"#$%&'()*+,-./:;<=>?@abcdefghijklmnopqrstuvwxyz[\\]^_`{|}~"; // excluding numbers characters
        public string exSpecial = "0123456789abcdefghijklmnopqrstuvwxyz"; // excluding special characters
        public string exNumbersSpecial = "abcdefghijklmnopqrstuvwxyz"; // excluding special and number characters
    }
}
