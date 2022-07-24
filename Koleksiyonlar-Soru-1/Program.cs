using System.Collections;
namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atılıp
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde dizilerin eleman sayısı ve ortalamasını 
            ekrana yazan konsol uygulaması ArrayList yapısı kullanılarak yazıldı*/

            ArrayList AsalListe=new ArrayList();

            ArrayList AsalOlmayanListe=new ArrayList();

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
                        int kontrol=0;

                        for(int i=2;i<sayi;i++){
                            if(sayi%i==0)
                            kontrol++;
                        }
                        if(kontrol != 0){
                            AsalOlmayanListe.Add(sayi);
                        }

                        else{
                            AsalListe.Add(sayi);
                        }
                        sayac++;
                    }
                       
                }

                catch(FormatException){

                    Console.WriteLine("Lutfen integer ve sifirdan buyuk bir deger girdiginize emin olun!");

                
                }

            }

            AsalListe.Sort();
            int AsalToplam=0;

            Console.Write("Asal Liste Elemanları: ");
            foreach(var item in AsalListe){

                Console.Write(item+" ");

                int tmp=Convert.ToInt32(item);
                AsalToplam +=tmp;
            }
            Console.WriteLine();
            Console.WriteLine("Asal Liste Ortalaması: "+ (double)AsalToplam/AsalListe.Count);



            AsalOlmayanListe.Sort();
            int AsalOlmayanToplam=0;

            Console.Write("Asal Olmayan Liste Elemanları: ");
            foreach(var item in AsalOlmayanListe){

                Console.Write(item+" ");

                int tmp=Convert.ToInt32(item);
                AsalOlmayanToplam +=tmp;
            }
            Console.WriteLine();
            Console.WriteLine("Asal Olmayan Liste Ortalaması: "+ (double)AsalOlmayanToplam/AsalOlmayanListe.Count);


        }
    }
}