using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakDB.Service
{
    class ilcs
    {
        public static void Insert(iller iller)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            Entities.iller.Add(iller);
            Entities.SaveChanges();
        }
        public static void Update(iller iller)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.iller.Where(x => x.il_ID == iller.il_ID).FirstOrDefault();
            if (YeniEv != null)
            {
                YeniEv.il_isim = iller.il_isim;
              
                Entities.SaveChanges();
            }

        }

        public static void SIL(iller iller)
        {
            emlakDBEntities Entities = new emlakDBEntities();
            var YeniEv = Entities.iller.Where(x => x.il_ID == iller.il_ID).FirstOrDefault();
            if (YeniEv != null)
            {
                YeniEv.IS_FLAG = 0;
                Entities.SaveChanges();
            }
            //  Entities.KATEGORILER.Remove(Personel); //( DATABASE'DEN SİLME İŞLEMİNİ YAPAR REMOVE KOMUTU)
        }

        public static List<View_iller_LIST> LISTELE()
        {
            emlakDBEntities Entities = new emlakDBEntities();
            List<View_iller_LIST> iller_LIST = Entities.View_iller_LIST.ToList();
            return iller_LIST;
        }

    }
}
