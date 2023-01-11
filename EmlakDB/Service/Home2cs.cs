using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakDB.Service
{
  public  class Home2cs
    {
        public static void Insert(Home2 Evler)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            Entities.Home2.Add(Evler);
            
            Entities.SaveChanges();
        }
        public static void Update(Home2 Evler)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.Home2.Where(x => x.EvID == Evler.EvID).FirstOrDefault();
            
            if (YeniEv != null)
            {
              

                YeniEv.OdaSayisi = Evler.OdaSayisi;
                YeniEv.KatNumarasi = Evler.KatNumarasi;
                YeniEv.ToplamEvAlani = Evler.ToplamEvAlani;
                YeniEv.YapimTarihi = Evler.YapimTarihi;
                YeniEv.EvDurumu = Evler.EvDurumu;

                YeniEv.ilce_ID = Evler.ilce_ID;

                YeniEv.il_ID = Evler.il_ID;

                YeniEv.Fiyat = Evler.Fiyat;
                YeniEv.Depozito = Evler.Depozito;
                YeniEv.Kapora = Evler.Kapora;
                YeniEv.Sözleşme = Evler.Sözleşme;
                YeniEv.Caymabedeli = Evler.Caymabedeli;
                YeniEv.Evresim = Evler.Evresim;


                Entities.SaveChanges();
            }

        }


        public static void SIL(Home2 Evler)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.Home2.Where(x => x.EvID == Evler.EvID).FirstOrDefault();
            if (YeniEv != null)
            {
                YeniEv.IS_FLAG = 0;
                Entities.SaveChanges();
            }
            //  Entities.KATEGORILER.Remove(Personel); //( DATABASE'DEN SİLME İŞLEMİNİ YAPAR REMOVE KOMUTU)
        }

        public static List<View_Home2_LIST> LISTELE()
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_Home2_LIST> Home_LIST = Entities.View_Home2_LIST.ToList();
            return Home_LIST;
        }


        public static List<View_Home2_LIST> SORGULA()
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_Home2_LIST> Home_LIST = Entities.View_Home2_LIST.ToList();
            return Home_LIST;
        }

    
        public static List<View_Home2Satilik_LIST> SATILIK()
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_Home2Satilik_LIST> Home_LIST = Entities.View_Home2Satilik_LIST.ToList();
            return Home_LIST;
        }

        public static List<View_Home2Kiralik_LIST> KIRALIK()
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_Home2Kiralik_LIST> Home2_LIST = Entities.View_Home2Kiralik_LIST.ToList();
            return Home2_LIST;
        }
        public static List<View_Home2_LIST> DETAYLISTELE(string il_ID, string ilce_ID)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_Home2_LIST> Home2_LIST = null;
            if (il_ID==string.Empty && ilce_ID==string.Empty)
            {
                 Home2_LIST = Entities.View_Home2_LIST.ToList();
           
            }
            if (il_ID != string.Empty && ilce_ID == string.Empty)
            {
                 Home2_LIST = Entities.View_Home2_LIST.Where(x => x.il_isim.ToString() == il_ID).ToList();
            }
            if (il_ID != string.Empty && ilce_ID != string.Empty)
            {
                 Home2_LIST = Entities.View_Home2_LIST.Where(x => x.il_isim.ToString() == il_ID &&  
                x.ilce_isim.ToString()==ilce_ID).ToList();

            }

            return Home2_LIST;
        }

        public static List<View_ilceler_LIST> DETAYLISTELE1(string il_ID, string ilce_ID)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_ilceler_LIST> ilceler2 = null;
            if (il_ID == string.Empty && ilce_ID == string.Empty)
            {
                ilceler2 = Entities.View_ilceler_LIST.ToList();

            }
            else if (il_ID != string.Empty && ilce_ID == string.Empty)
            {
                ilceler2 = Entities.View_ilceler_LIST.Where(x => x.il_ID.ToString() == il_ID).ToList();
            }
            else if (il_ID != string.Empty && ilce_ID != string.Empty)
            {
                ilceler2 = Entities.View_ilceler_LIST.Where(x => x.il_ID.ToString() == il_ID &&
               x.ilce_isim.ToString() == ilce_ID).ToList();

            }

            return ilceler2;
        }

    }
}
