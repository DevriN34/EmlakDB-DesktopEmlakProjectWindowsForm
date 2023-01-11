using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakDB.Service
{
    public class HomeDetailscs
    {
        public static void Insert(HomeDetails home)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            Entities.HomeDetails.Add(home);
            Entities.SaveChanges();
        }
        public static void Update(HomeDetails Evler)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.HomeDetails.Where(x => x.HomedetailsID == Evler.HomedetailsID).FirstOrDefault();
            if (YeniEv != null)
            {
                
                YeniEv.PersonelID = Evler.PersonelID;
                YeniEv.Notes = Evler.Notes;
                YeniEv.HomedetailsID = Evler.HomedetailsID;
               
               


                Entities.SaveChanges();
            }

        }

        public static void SIL(HomeDetails Evler)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.HomeDetails.Where(x => x.HomedetailsID == Evler.HomedetailsID).FirstOrDefault();
            if (YeniEv != null)
            {
                YeniEv.IS_FLAG = 0;
                Entities.SaveChanges();
            }
            //  Entities.KATEGORILER.Remove(Personel); //( DATABASE'DEN SİLME İŞLEMİNİ YAPAR REMOVE KOMUTU)
        }

        public static List<View_HomeDetails_LIST> LISTELE()
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_HomeDetails_LIST> HomeDetay_LIST = Entities.View_HomeDetails_LIST.ToList();
            return HomeDetay_LIST;
        }


        public static List<View_Home2Satilik_LIST> SORGULA()
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_Home2Satilik_LIST> Home_LIST = Entities.View_Home2Satilik_LIST.ToList();
            return Home_LIST;
        }

        public static List<View_Home2Kiralik_LIST> SORGULA1()
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_Home2Kiralik_LIST> Home_LIST = Entities.View_Home2Kiralik_LIST.ToList();
            return Home_LIST;
        }
    }
}
