/* *********************************** KAPSÜLLEME **********************************
Bir sınıfa ait verilerin ya da özelliklerin paketlenmesi.
Avantajları:
1- Verilerin güvenliği
2- Kod karmaşasını azaltır.
3- Esneklik
4- Kodların test edilebilirliğini kolaylaştırır.
İsimli temel ana sınıf tarafından erişilir.
Kişi adı değeri ayarlanır (get) ve ayarlanır (set)
*/

/*using System;

public class Kapsulleme
{
    // bu kısımdaki verilere yalnızca Kapsulleme
    // isimli temel(ana) sınıf tarafından erişilir
    private String Isim;
    private int Yas;

    // Erişimcileri kullanarak (get) ve ayarlanır (set)
    public String KisiAdi
    {
        get { return Isim; } 
        set { Isim = value; }
    }

    // Yukarıda olduğu gibi kişi yaşı
    // değeri alınır ve ayarlanır
    public int KisiYasi
    {
        get { return Yas; }
        set { Yas = value; }
    }
}

class FKA
{
    // Main method
    static public void Main()
    {
        // nesne oluşturulur
        Kapsulleme obj = new Kapsulleme();

        // Kişi adı özelliğinin set erişimcisi çağırılır
        // Kişi adına burada girilen değer atanır.
        obj.KisiAdi = "Berfin";


        // Yukarıda olduğu gibi kişi yaşına set erişimcisi ile yaş değeri atanır
        obj.KisiYasi = 24;

        // Değişkinler ekranda gösterilir.
        Console.WriteLine(" Isim : " + obj.KisiAdi);
        Console.WriteLine(" Yaş : " + obj.KisiYasi);


    }

}
*/


//using System;

//public class Bankamatik
//{
//    private int _bakiye;
//    private int yeni_bakiye;
//        public int gorme
//    {
//        get { return _bakiye; }
//        set { _bakiye = value; }
//    }
//    public int ekleme
//    {
//        get { return yeni_bakiye;}
//        set { yeni_bakiye = value; }
//     }

//}
//class Atm
//{
//    static public void Main ()
//    {
//        Bankamatik obj = new Bankamatik();
//        obj.gorme = 1000;
//        obj.ekleme = 500;
//        obj.ekleme += 1000;


//        Console.WriteLine("_bakiye: " + obj.gorme);
//        Console.WriteLine("yeni_bakiye: " + obj.ekleme);
//    }
//}

/*
 * Metot bir programdaki kod veya kod bloklarına verilen adıdır.
 * - Aynı kodları yeniden kullanabilme hakkı tanır.
 * - Bellek kullanımında anataj sağlar.
 * - Okunabilir kod yazmayı sağlar.
 * - Zaman tasarrufu sağlar.
 * Bir işlem gerçekleştirilir ve karşılığında bizlere bir ifade döndürür.
 * ya da hiçbir şey döndürmeyen metotlarda bulunabilir.
 * Syntax Yapısı:
 * Modifier + Döndürme Tipi + Metot Adı + Alınan Parametreler 
 * public string GetKullaniciAdi (string ad, string soyad)
 * 
 * Metot adı bir isim ya da fiil olması gerekir.
 * Metotun adı yapılacak işi anlatmalıdır.
 * Metot adı genellikle büyük harfle başlaması tavsiye edilir.
 * 
 * Metot Parametreleri:
 * Adlandırılmış Parametreler
 * Referans Parametreleri
 * Çıkış Parametreler
 * Varsayılan veya İsteğe Bağlı Parametreler 
 * Dinamik Parametreler
 * Değer Parametreler
 * Params Parametreler
 */

//using System;
//using System.ComponentModel.Design;
//using System.Security.Cryptography.X509Certificates;
//using System.Transactions;

//public class SifreBelirleme
//{
//    private string name;
//    private int id;
//    public string isim
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public int kullanici
//    {
//        get { return id; }
//        set { id = value; }
//    }
//}

//class Belirleme
//{
//    private static string name;

//    static void Main()
//    {
//        if (name == "Berfin")
//        {
//            Console.WriteLine("Kullanıcı adı doğru");
//        }
//        else (name != " Berfin")
//        {
//             Console.WriteLine("Girdiğiniz isim yanlış.");
//        }

//        if (id == "136")
//        {
//            Console.WriteLine("Kullanıcı id doğru");
//        }
//        else (id != "136")
//        {
//            Console.WriteLine("Girdiğiniz id yanlış.");

//        }
//    }

//}



/* ************************************* Override************************************
 * Türetilmiş başka bir sınıftan özellik alması
 */

//using System;

//// Base class
//class baseClass
//{
//    public virtual void show()
//    {
//        Console.WriteLine("Base class");
//    }
//}

//// Base classtan --> Türetilmiş sınıf 
//class turetilmisSinif : baseClass
//{

//  // overriding
//  public override void show()
//    {
//        Console.WriteLine("Türetilmiş class");
//    }
//}
//class FKA
//{
//    public static void Main()
//    {
//        // Base class a ait obj adındaki nesne oluşturma
//        baseClass obj = new baseClass();

//        // Base class objesini gösterme
//        obj.show();
//        // turetilmisSinifa ait obj adındaki nesneyi oluşturma
//        obj = new turetilmisSinif();

//        // show metoduyla turetilmis sinifa ait obj nesnesini gösterme
//        obj.show();
//    }
//}





