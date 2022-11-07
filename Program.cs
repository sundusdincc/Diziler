internal class Program
{
    private static void Main(string[] args)
    {   //Dizi tanımlama
        string[] renkler = new string[5];
        string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };
        int[] dizi;
        dizi = new int[5];

        //Dizilere değer atama ve erişim
        renkler[0] = "Mavi";
        dizi[3] = 10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //Döngülerle dizi kullanımı
        //Klavyeden girilen n tane sayının ortalamasını hesaplayan program
        Console.Write("Lütfen dizinin eleman sayısını giriniz:");
        int diziuzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziuzunlugu];

        int toplam1 = 0;
        for (int i = 0; i < diziuzunlugu; i++)
        {
            Console.Write("Lütfen {0}. sayıyı giriniz:", i + 1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());

            //dizideki sayiların n katının ortalaması
            toplam1 += sayiDizisi[i] * 2;

        }

        int toplam = 0;
        foreach (var sayi in sayiDizisi)
        {
            toplam += sayi;
        }
        Console.WriteLine("Ortalama: " + toplam / diziuzunlugu);
        Console.WriteLine("Ortalama1: " + toplam1 / diziuzunlugu);


        //Geeks
        // declares an Array of integers.
        int[] intArray;

        // allocating memory for 5 integers.
        intArray = new int[5];

        // initialize the first elements
        // of the array
        intArray[0] = 10;

        // initialize the second elements
        // of the array
        intArray[1] = 20;

        // so on...
        intArray[2] = 30;
        intArray[3] = 40;
        intArray[4] = 50;

        // accessing the elements
        // using for loop
        Console.Write("For loop :");
        for (int i = 0; i < intArray.Length; i++)
            Console.Write(" " + intArray[i]);

        Console.WriteLine("");
        Console.Write("For-each loop :");

        // using for-each loop
        foreach (int i in intArray)
            Console.Write(" " + i);

        Console.WriteLine("");
        Console.Write("while loop :");

        // using while loop
        int j = 0;
        while (j < intArray.Length)
        {
            Console.Write(" " + intArray[j]);
            j++;
        }

        Console.WriteLine("");
        Console.Write("Do-while loop :");

        // using do-while loop
        int k = 0;
        do
        {
            Console.Write(" " + intArray[k]);
            k++;
        } while (k < intArray.Length);
    }



}