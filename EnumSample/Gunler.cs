using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    public enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    public enum Renkler
    {
        [Display(Name = "Sarı v Mavi")]
        SarıVeMavi,
        Sarı,
        Turuncu,
        Kırmızı,
        Yeşil,
        Siyah,
        Beyaz
    }

    public enum RGB : byte
    {
        Red = 2, Green = 4, Blue = 8
    } 
}
