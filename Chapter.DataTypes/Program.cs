using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sayisal veri tipleri
            // Tamsayi Degisken Tipleri (Integer Variable Types)
            byte nuri = 13; //0 ile 255 arasi sayisal degeri belirtir. (1Byte)
            sbyte snuri = -13; //-128 ile 127 arasi sayisal degeri belirtir. (1Byte)
            short shnuri = 7; //-32768 ile 32767 arasi sayisal degeri belirtir. (2Byte)
            ushort ushnuri = 70; //0 ile 65535 arasi sayisal degeri belirtir. (2Byte)
            int intnuri = 700; //-21474843648 ile 2147483648 arasi sayisal degeri belirtir. (4Byte)
            uint uintnuri = 701; //0 ile 4294967295 arasi sayisal degeri belirtir. (4Byte)
            long longnuri = 7000; //-10^20 ile 10^20 arasi sayisal degeri belirtir. (8Byte)
            ulong ulongnuri = 70001; //0 ile 2*10^20 arasi sayisal degeri belirtir. (8Byte)
            Calculator calculator = new Calculator();
            int caltotal = calculator.CalTotal(27, 15);
            int calimpact = calculator.CalImpact(12, 20);
            long calminus = calculator.CalMinus(2016, 1988);
        }
    }
}
