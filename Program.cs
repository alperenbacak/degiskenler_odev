using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String degisken = " ";
            byte b=5;  //1byte yer kaplar 0-255
            sbyte c=5; //1byte yer kaplar -128-+127
            short s = 5; //2byte yer kaplar
            ushort us = 5; //2byte 
            Int16 i16 = 2;  //2byte
            int i = 2; //2byte
            Int32 i32 = 2; //4byte
            Int64 i64 = 2; //4byte

            uint ui = 2; //4byte
            long l = 4; //8byte
            ulong ul = 4;   //8byte
            
            //REEL SAYILAR
            float f = 5;    //4byte
            double d = 5;   //8byte
            decimal de = 5; //16byte

            char ch = '2';  //2byte
            string str = "alperen"; //sınırsız
            bool b1= true;
            bool b2 = false;

            DateTime dt =DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // String Ifadeler

            string str1 = string.Empty;
            str1 = "alperen bacak";
            string ad = "alperen";
            string soyad = "bacak";
            string tamisim = ad + " " + soyad;

            // Integer tanımlama tipleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //boolean

            bool bo1 = 10<2;

            //degisken donusumleri
            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine (yenideger);

            int int21 = int20 +  Convert.ToInt32(str20);
            Console.WriteLine(int21); 

            //DateTime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string datetime3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime3);











        }
    }
}
