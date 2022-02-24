using System;

namespace UcakBiletFiyatiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Mesafeye ve şartlara göre uçak bileti fiyatı hesaplayan programı yapın. Kullanıcıdan Mesafe (KM), yaşı ve yolculuk tipi (Tek Yön, Gidiş-Dönüş) bilgilerini alın. Mesafe başına ücret 0,10 TL / km olarak alın. İlk olarak uçuşun toplam fiyatını hesaplayın ve sonrasında ki koşullara göre müşteriye aşağıdaki indirimleri uygulayın ;

           * Kullanıcıdan alınan değerler geçerli (mesafe ve yaş değerleri pozitif sayı, yolculuk tipi ise 1 veya 2) olmalıdır. Aksi takdirde kullanıcıya "Hatalı Veri Girdiniz !" şeklinde bir uyarı verilmelidir.
           * Kişi 12 yaşından küçükse bilet fiyatı üzerinden %50 indirim uygulanır.
           * Kişi 12-24 yaşları arasında ise bilet fiyatı üzerinden %10 indirim uygulanır.
           * Kişi 65 yaşından büyük ise bilet fiyatı üzerinden %30 indirim uygulanır.
           * Kişi "Yolculuk Tipini" gidiş dönüş seçmiş ise bilet fiyatı üzerinden %20 indirim uygulanır.
            
            */
            int km,age;
            byte _type;
            double amount=0,ageDiscountPercent,typeDiscountPercent;
            Console.Write("Mesafeyi giriniz: ");
            km=Convert.ToInt16(Console.ReadLine());
            Console.Write("Yaşınızı giriniz: ");
            age=Convert.ToInt16(Console.ReadLine());
            Console.Write("Yolculuk tipini seçiniz(Tek yön -> 1 , Gidiş-dönüş ->2) : ");
            _type=Convert.ToByte(Console.ReadLine());
            string errorMessage= km<0 || age<0 || !(_type>0 && _type<3) ? "Hatalı veri girdiniz!": "";
            Console.Write(errorMessage);
            amount=km * 0.1;
            ageDiscountPercent= age<12 ? 0.5 :(age>12 && age<24 ? 0.1 : (age>65 ? 0.3: 0));
            typeDiscountPercent= _type==2 ? 0.2 : 0;
            amount-=amount*ageDiscountPercent;
            amount-=amount*typeDiscountPercent;
            Console.WriteLine(errorMessage=="" ? "Toplam tutar: "+ amount: "");
        }
    }
}
