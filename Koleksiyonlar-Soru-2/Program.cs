using System.Collections;
namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her 
            iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran program.*/

            int[] sayilar=new int[20];

            Console.WriteLine("20 adet sayi giriniz: ");

            int sayac=1;

            while(sayac<21){

                try{
                    Console.Write(sayac+". sayi: ");

                    int sayi_;
                    int sayi;

                    sayi_=Convert.ToInt32(Console.ReadLine());

                    if(sayi_<=0){

                        throw new FormatException();

                    }

                    else{

                        sayi=sayi_;

                        sayilar[sayac-1]=sayi;
                        
                        sayac++;
                       
                    }
                       
                }

                catch(FormatException){

                    Console.WriteLine("Lutfen integer ve sifirdan buyuk bir deger girdiginize emin olun!");

                
                }

            }

            Array.Sort(sayilar);

            Console.WriteLine();
            Console.Write("En büyük sayilar: "+sayilar[17]+" "+sayilar[18]+" "+sayilar[19]);
            Console.WriteLine();
            Console.Write("En büyük sayilar ortalama: "+(double) ((sayilar[17]+sayilar[18]+sayilar[19])/3));

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("En kücük sayilar: "+sayilar[0]+" "+sayilar[1]+" "+sayilar[2]);
            Console.WriteLine();
            Console.Write("En kücük sayilar ortalama: "+(double) ((sayilar[0]+sayilar[1]+sayilar[2])/3));





            






        }
    }
}