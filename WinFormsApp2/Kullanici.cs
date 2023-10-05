using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Kullanici
    {
        private string isim;
        public string Isim
        {
            get { return isim; }
            set { if (value.Length > 2) isim = value; else throw new Exception("isim 2 den uzun olmalı"); }
        }

        public string Soyisim { get; set; }
        private string tc;
        public string Email { get; set; }
        public string Cinsiyet { get; set; }

        public string Tc
        {
            get
            {
                return tc;
            }
            set
            {
                if (value.Length != 11 || !IsNumeric(value))
                {
                    throw new Exception("Tc Numarası 11 haneli ve sadece sayılardan oluşmalıdır");
                }
                else
                {
                    tc = value;
                }
            }
        }



        private bool IsNumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
