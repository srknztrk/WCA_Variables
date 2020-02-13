using System;

namespace WCA_Variables
{
    class Program
    {
        public static int Ctrl { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Ctrl + K + D;
            //Ctrl + E + W;
            //Ctrl + K + C;
            //Ctrl + K + U;
            //Ctrl + Shift + B;
            //Ctrl + D;

            byte     sayi1 = 56;
            sbyte    sayi2 = 12;
            short    sayi3 = 134;
            ushort   sayi4 = 123;
            int      sayi5 = 324;//en çok kullanılan
            uint     sayi6 = 21432432;
            long     sayi7 = 324234;
            ulong    sayi8 = 23424;
            float    sayi9 = 12.0F;
            double   sayi10 = 12.0;
            decimal  sayi11 = 12.0M;

            char   karakter = 'A';//tek karakter_tek tırnak
            string metin1 = "Bilge Adam Beşiktaş Yazılım Dersleri"; //çift tırnak
            string metin2 = "Bilge\nAdam\nBeşiktaş\nYazılım\nDersleri";//\n => yeni satir olustur
            string tekkarakter = "A";
            

            //jetbrains.com
            //Console.Readkey();

            Console.WriteLine(metin1);

            string tabBosluk = "Bilge\tAdam";
            Console.WriteLine(tabBosluk);

            // => Bilge Adam Beşiktaş "Yazılım" Dersleri
            string metin3 = "Bilge Adam Beşiktaş\"Yazılım\"Dersleri"; // \" ayırma
            Console.WriteLine(metin3);

            bool sonuc = false;

            bool result = 10 > 2;
            Console.WriteLine(result);













        }
    }
}
