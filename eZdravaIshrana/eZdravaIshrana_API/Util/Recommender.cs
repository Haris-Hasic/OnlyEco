using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eZdravaIshrana_API.Models;

namespace eZdravaIshrana_API.Util
{
    public class Recommender
    {
        eZdravaIshranaEntities db = new eZdravaIshranaEntities();
        Dictionary<int, List<Ocjene>> proizvodi = new Dictionary<int, List<Ocjene>>();

        public List<esp_Proizvodi_ByProizvodID_Result> GetSlicneProizvode(int proizvodID)
        {
            UcitajProizvode(proizvodID);
            List<Ocjene> ocjenePosmatranogProizvoda = db.Ocjene.Where(x => x.ProizvodID == proizvodID).OrderBy(x => x.KupacID).ToList();

            List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
            List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();
            List<esp_Proizvodi_ByProizvodID_Result> preporuceniProizvodi = new List<esp_Proizvodi_ByProizvodID_Result>();

            foreach (var item in proizvodi)
            {
                foreach (Ocjene o in ocjenePosmatranogProizvoda)
                {
                    if (item.Value.Where(x => x.KupacID == o.KupacID).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KupacID == o.KupacID).First());
                    }
                }
                double slicnosti = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnosti > 0.95)
                    preporuceniProizvodi.Add(db.esp_Proizvodi_ByProizvodID(item.Key).FirstOrDefault());
                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return preporuceniProizvodi;
        }

        private double GetSlicnost(List<Ocjene> zajednickeOcjene1, List<Ocjene> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                brojnik += zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena;
                nazivnik1 += zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena;
                nazivnik2 += zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena;
                
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);
            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            return brojnik / nazivnik;
        }

        private void UcitajProizvode(int proizvodID)
        {
            List<Proizvodi> aktivniProizvodi = db.Proizvodi.Where(x => x.ProizvodID != proizvodID && x.Status == true).ToList();
            List<Ocjene> ocjene;
            foreach (Proizvodi p in aktivniProizvodi)
            {
                ocjene = db.Ocjene.Where(x => x.ProizvodID == p.ProizvodID).OrderBy(x => x.KupacID).ToList();
                if (ocjene.Count > 0)
                    proizvodi.Add(p.ProizvodID, ocjene);
            }
        }
    }
}