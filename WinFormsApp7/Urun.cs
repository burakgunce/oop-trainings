using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    public class Urun
    {
		private int urunId;

		public int UrunId
		{
			get { return urunId; }
			set 
			{
                if (value == null)
                {
					throw new Exception("Ürün Id boş geçilemez !!!");
                }
                else if (value.ToString().Length != 6)
                {
                    throw new Exception("Ürün Id 6 karakter olmalıdır !!!");
                }
				urunId = value;

            }
		}

		private string urunAdi;

		public string UrunAdi
		{
			get { return urunAdi; }
			set 
			{
                if (value.Length < 3)
                {
					throw new Exception("Ürün adı en az 3 karakter olmalıdır !!!");
                }
                urunAdi = value; 
			}
		}

		private string urunAciklamasi;

		public string UrunAciklamasi
		{
			get { return urunAciklamasi; }
			set 
			{
                if (!value.StartsWith(urunAdi))
                {
					throw new Exception("Ürün açıklaması ürün adı ile başlamalıdır !!!");
                }
                urunAciklamasi = value; 
			}
		}

		private DateTime uretimTarihi;

		public DateTime UretimTarihi
		{
			get { return uretimTarihi; }
			set 
			{
                if (value > DateTime.Now)
                {
					throw new Exception("Üretim tarihi gelecek bir gün olamaz !!!");
                }
                uretimTarihi = value; 
			}
		}

		private DateTime garantiSuresi;

		public DateTime GarantiSuresi
		{
			get { return garantiSuresi; }
			set 
			{
                if (value <= DateTime.Now)
                {
					throw new Exception("Garanti süresi bugün veya önceki bir tarih olamaz !!!");
                }
                garantiSuresi = value; 
			}
		}

	}
}
