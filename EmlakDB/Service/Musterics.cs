using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakDB.Service
{
    class Musterics
    {
        public static void Insert(Musteri musteri)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            Entities.Musteri.Add(musteri);
            Entities.SaveChanges();
        }
        public static void Update(Musteri musteri)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.Musteri.Where(x => x.EvID == musteri.EvID).FirstOrDefault();
            if (YeniEv != null)
            {
                YeniEv.Ad = musteri.Ad;
                YeniEv.Soyad = musteri.Soyad;
                
                YeniEv.EvID = musteri.EvID;
                YeniEv.TelefonNO = musteri.TelefonNO;

                Entities.SaveChanges();
            }

        }

        public static void SIL(Musteri musteri)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.Musteri.Where(x => x.MusteriID == musteri.MusteriID).FirstOrDefault();
            if (YeniEv != null)
            {
                YeniEv.IS_FLAG = 0;
                Entities.SaveChanges();
            }
            //  Entities.KATEGORILER.Remove(Personel); //( DATABASE'DEN SİLME İŞLEMİNİ YAPAR REMOVE KOMUTU)
        }

        public static List<View_Musteri_LIST> LISTELE()
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_Musteri_LIST> Musteri_LIST = Entities.View_Musteri_LIST.ToList();
            return Musteri_LIST;
        }

    }
}
