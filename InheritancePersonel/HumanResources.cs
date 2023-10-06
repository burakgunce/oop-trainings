using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePersonel
{
    public class HumanResources : Human
    {
        public bool IseAlabilir { get; set; }
        public bool UcretBelirleyebilir { get; set; }
        public bool CalismaSaatiBelirleyebilir { get; set; }

        public HumanResources(string adSoyad, DateTime dogumTarihi, bool cinsiyet, double kilo, double boy, bool ehliyetVarMi, bool saglikSorunuVarMi,
            decimal aldigiUcret, bool iseAlabilir, bool ucretBelirleyebilir, bool calismaSaatiBelirleyebilir)
        {
            AdSoyad = adSoyad;
            DogumTarihi = dogumTarihi;
            Cinsiyet = cinsiyet;
            Kilo = kilo;
            Boy = boy;
            EhliyetVarMi = ehliyetVarMi;
            SaglikSorunuVarMi = saglikSorunuVarMi;
            AldigiUcret = aldigiUcret;
            IseAlabilir = iseAlabilir;
            UcretBelirleyebilir = ucretBelirleyebilir;
            CalismaSaatiBelirleyebilir = calismaSaatiBelirleyebilir;

            EkranaYaz();
        }

        private void EkranaYaz()
        {
            string info = $"{AdSoyad} isimli insan kaynakları birimi personelinin : \n {DogumTarihi}  {Cinsiyet}  {Kilo}  {Boy}  " +
                $"{(EhliyetVarMi ? "Var" : "Yok")} {(SaglikSorunuVarMi ? "Var" : "Yok")}  {AldigiUcret}  {(IseAlabilir ? "Alabilir" : "Alamaz")} " +
                $"{(UcretBelirleyebilir ? "Belirleyebilir" : "Belirleyemez")}  {(CalismaSaatiBelirleyebilir ? "Belirleyebilir" : "Belirleyemez")}";
            Console.WriteLine(info);
        }
    }
}
