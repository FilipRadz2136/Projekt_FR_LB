namespace Projekt_FR_ŁB_NET.Models
{
	public class HistoriaWymianUzytkownika
	{
			public int Id { get; set; }

			public int UzytkownikId { get; set; }
			public Uzytkownik Uzytkownik { get; set; }

			public decimal KwotaWejsciowa { get; set; }

			public int WalutaZId { get; set; }
			public Waluta WalutaZ { get; set; }

			public int WalutaDoId { get; set; }
			public Waluta WalutaDo { get; set; }

			public decimal KwotaWynikowa { get; set; }
			public DateTime DataPrzeliczenia { get; set; }
	}
}
