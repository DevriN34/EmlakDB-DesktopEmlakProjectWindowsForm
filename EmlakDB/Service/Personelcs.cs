using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakDB.Service
{
  public  class Personelcs
    {
        public static void Insert(Personel Evler)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            Entities.Personel.Add(Evler);

            Entities.SaveChanges();
        }
        public static void Update(Personel personel)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.Personel.Where(x => x.PersonelID == personel.PersonelID).FirstOrDefault();

            if (YeniEv != null)
            {


                YeniEv.PersonelAd = personel.PersonelAd;
                YeniEv.PersonelSoyad = personel.PersonelSoyad;
                YeniEv.TCKN = personel.TCKN;
               



                Entities.SaveChanges();
            }

        }
        public static void SIL(Personel Evler)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.Personel.Where(x => x.PersonelID == Evler.PersonelID).FirstOrDefault();
            if (YeniEv != null)
            {
                YeniEv.IS_FLAG = 0;
                Entities.SaveChanges();
            }
            //  Entities.KATEGORILER.Remove(Personel); //( DATABASE'DEN SİLME İŞLEMİNİ YAPAR REMOVE KOMUTU)
        }

        public static List<View_Personel_LIST> LISTELE()
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_Personel_LIST> Home_LIST = Entities.View_Personel_LIST.ToList();
            return Home_LIST;
        }

    }
}
