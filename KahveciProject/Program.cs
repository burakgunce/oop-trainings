using KahveciProject.Abstract;
using KahveciProject.Concrete;
using KahveciProject.Enums;
using KahveciProject.Utilities;

namespace KahveciProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonelHelper personelHelper = new PersonelHelper();
            Siparis siparis = new Siparis();

            Dukkan dukkan = new Dukkan();
            Musteri musteri = new Musteri();
            FiltreKahve kahve = new FiltreKahve();
            Kahve siparisEdilenKahve = musteri.SiparisVer(kahve);
            Siparis.Kahveler.Add(siparisEdilenKahve);

            Personel personel1 = new Personel();
            personel1.Durum = Durum.Musait;
            Dukkan.Personeller.Add(personel1);

            Personel personel2 = new Personel();
            personel2.Durum = Durum.Mesgul;
            Dukkan.Personeller.Add(personel2);

            bool elemanVarmi = personelHelper.BosPersonelVarMi(Dukkan.Personeller);
            if (elemanVarmi == true)
            {
                personel1.SiparisAl(siparisEdilenKahve);
                personel1.SiparisHazirla();
            }
            else { Console.WriteLine("suan bosta personel olmadıgı ıcın sıparıs verılemıyor "); }


            

            
        }
    }
}