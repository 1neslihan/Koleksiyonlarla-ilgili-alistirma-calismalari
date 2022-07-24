using System.Collections;
namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

           // Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi 
           //içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            
           try{

            Console.Write("Bir cümle giriniz: ");
            string str=Console.ReadLine(); 

           if(str=="" || str==" "){
                throw new ArgumentException();
            }
            
            str.ToLower();
            char[] chrArr=str.ToArray();

            ArrayList dizi=new ArrayList();

            for(int i=0;i<chrArr.Length;i++){
                if(chrArr[i]=='a' || chrArr[i]=='e' || chrArr[i]=='ı' || chrArr[i]=='i' || chrArr[i]=='o' || chrArr[i]=='ö' || chrArr[i]=='u' || chrArr[i]=='ü' ){
                    dizi.Add(Convert.ToString(chrArr[i]));
                }
            }

            dizi.Sort();
            Console.WriteLine();
            Console.Write("sesli harfler: ");

            foreach(var item in dizi){
                Console.Write(item);
            }
            
           }

           catch(ArgumentException){
                Console.WriteLine("İfade boş bırakılamaz");
           }
            
        }
    }
}