//ORU4: 1-50 arasındaki tam sayılardan 3 katının 2 fazlası 5'e tam bölünenleri bulup, bu sayıların hangi sayılar olduğunu ekrana yazdıran algoritma ve akış diyagramı.



namespace MyNamespace1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BeseBölünenSayilar();
        }

        static void BeseBölünenSayilar()
        {
            try
            {
                Console.WriteLine("Lütfen Başlangı Sayisini Giriniz");
                int sayi1 = Convert.ToInt32 (Console.ReadLine());
                Console.WriteLine("Lütfen Bitiş Sayisini Giriniz");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                for (int i = sayi1; i < sayi2; i++)
                {
                    if (((i * 3) + 2) % 5 == 0)
                    { 
                        Console.WriteLine($"5'e Tam Bölünür = {i}"); 
                    }
                    
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }
    }

}

