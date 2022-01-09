using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // ***** out parameters ******* //

            string sayi ="999";
            int outSayi;

            bool sonuc = int.TryParse(sayi,out outSayi);
            if(sonuc)
            Console.WriteLine("BASARILI !! "+outSayi);
            else
            {
                Console.WriteLine("Başarısız !!!"); 
            }

            Metotlar instance = new Metotlar();
            instance.Topla(7,6,out int toplamSonucu);

            Console.WriteLine(toplamSonucu);

            //********* Method Overloading *****//

            int deger = 1234;
            instance.EkranaYazdir(deger);
            instance.EkranaYazdir("Batuhan","ALTINEL");

        }
    }
    class Metotlar{

        public void Topla(int a,int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+" "+veri2);
        }
    }
}
