using System;

namespace plakşirketi2
{
    class Program
    {
        /***********************************************************
        **
        **                    SAKARYA ÜNİVERSİTESİ
        **             BİLGİSAYAR VE BİLİŞİM FAKÜLTESİ
        **           BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
        **            NESNEYE DAYALI PROGRAMLAMA DERSİ
        **                   2019-2020 BAHAR DÖNEMİ
        **       ÖDEV NUMARASI:1
        **       ÖĞRENCİ ADI: BİLGE DAL
        **       ÖĞRENCİ NUMARASI: B191200038
        **       DERSİN ALDIĞI GRUP: A GRUBU
        *************************************************************/


        static void Main(string[] args)
        {
            Console.WriteLine("Plak Şirketimize Hoşgeldiniz:)");

            /*Öncelikle kullanıcıya hangi sene/dönemin plağıyla ilgilendiğini sorarak, elimizdeki o 
            döneme ait plak sayısı hakkında bilgilendirme yapıyoruz.*/


            int sorulansene;


            Console.Write("Plak sayısı hakkında bilgi almak istediğiniz seneyi sene'inci(.) halinde yazınız:");
            sorulansene= Convert.ToInt32(Console.ReadLine());
            if (sorulansene > 1970)
            {
                Console.WriteLine("Elimizde bulunmamaktadır.");

            }
            else if (1980 > sorulansene && sorulansene > 1970)
            {
                Console.WriteLine("10 plak bulunmaktadır.");
            }
            else if (1990 > sorulansene && sorulansene > 1980)
            {
                Console.WriteLine("23 plak bulunmaktadır.");
            }
            else if (2000 > sorulansene && sorulansene > 1990)
            {
                Console.WriteLine("26 plak bulunmaktadır.");
            }
            else if (sorulansene > 2000)
            {
                Console.WriteLine("Elimizde bulunmamaktadır.");
            }
            /* Şimdi ise aradıkları sanatçının plaklarının elimizde
    bulunup bulunmadığı hakkında bilgilendirme yapacağız.*/

            int sanatcı;
            int= zerrinozer;
            int= harunkolcak;

            Console.Write("Hangi sanatcımızın plagını arıyorsunuz:");
            sanatcı= Convert.ToInt32(Console.ReadLine());
            if (sanatcı == zerrinozer)
            {
                Console.WriteLine("Elimizde bu sanatcıya ait 16 plak bulunmaktadır.");
            }
            else if (sanatcı == harunkolcak)
            {
                Console.WriteLine("Elimizde bu sanatcıya ait 12 plak bulunmaktadır.");
            }
            else
            {
                Console.WriteLine("Elimizde aradıgınız sanatcıya ait plak yoktur.");
            }
            Console.WriteLine("Ugradıgınız icin tesekkurler");

            




        }
    }
}
