using System;

namespace recursive_extension_methots
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Rekürsif - Öz Yinelemeli
        //    3^4=81 bunu yapabiliriz.
            int result=1;
            for (int i = 1; i < 5; i++)
            {
                result=result*3;                
            }
            Console.WriteLine(result);
            islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

        //  Extension metotlar
        string ifade = "Ahmet Türkmenay";
        Console.WriteLine(ifade);
        bool sonuc = ifade.checkSpaces();
        Console.WriteLine(ifade.checkSpaces());
        if (sonuc)
            Console.WriteLine(ifade.RemoveSpaces());
        Console.WriteLine(ifade.MakeUpper());
        Console.WriteLine(ifade.MakeLower());
        

        int[] dizi = {15,12,11,8,3,0,7,6};
        dizi.sortArray();
        dizi.EkranaYaz();

        int sayi = 15;
        Console.WriteLine(sayi.isEvenNumber());
        Console.WriteLine(ifade.getFirstCharacter());


        
        }
    }
    public class islemler{
        public int Expo(int sayi, int üs)
        {
            if (üs<2)
                return sayi;
            return Expo(sayi, üs-1)*sayi;
        // Expo(3,4)=   expo(3,3)*3
        // Expo(3,3)=   expo(3,2)*3*3
        // Expo(3,2)=   expo(3,1)*3*3*3
        // Expo(3,1)=           3*3*3*3
        }
    }
    public static class extension{
        public static bool checkSpaces (this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveSpaces (this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("**",dizi);
        }
        public static string MakeUpper (this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLower (this string param)
        {
            return param.ToLower();
        }
        public static int[] sortArray (this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYaz (this int[] param)
        {
            foreach (int item in param)
                Console.WriteLine(item);
        }
        public static bool isEvenNumber (this int param)
        {
           return param%2 == 0;
        }
        public static string getFirstCharacter( this string param)
        {
            return param.Substring(0,1);
        }
    }   

}
