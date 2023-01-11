using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakDB.Service
{
    class ilcelercscs
    {
        public static void Insert(ilceler ilceler)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            Entities.ilceler.Add(ilceler);
            Entities.SaveChanges();
        }
        public static void Update(ilceler ilceler)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.ilceler.Where(x => x.ilce_ID == ilceler.ilce_ID).FirstOrDefault();
            if (YeniEv != null)
            {
                YeniEv.ilce_isim = ilceler.ilce_isim;
                YeniEv.il_ID = ilceler.il_ID;

                Entities.SaveChanges();
            }

        }

        public static void SIL(ilceler ilceler)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.ilceler.Where(x => x.ilce_ID == ilceler.ilce_ID).FirstOrDefault();
            if (YeniEv != null)
            {
                YeniEv.IS_FLAG = 0;
                Entities.SaveChanges();
            }
            //  Entities.KATEGORILER.Remove(Personel); //( DATABASE'DEN SİLME İŞLEMİNİ YAPAR REMOVE KOMUTU)
        }

        public static List<View_ilceler_LIST> LISTELE()
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_ilceler_LIST> ilceler_LIST = Entities.View_ilceler_LIST.ToList();
            return ilceler_LIST;
        }
        public static List<View_ilceler_LIST> LISTELE(string il_ID)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_ilceler_LIST> ilceler_LIST = Entities.View_ilceler_LIST.Where(x=> x.il_ID.ToString()==il_ID).ToList();
            return ilceler_LIST;
        }
    }
}
