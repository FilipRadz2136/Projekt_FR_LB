namespace Projekt_FR_ŁB_NET.Models
{
	public class KursWaluty
	{
			public int Id { get; set; }

			public int WalutaZId { get; set; }
			public Waluta WalutaZ { get; set; }

			public int WalutaDoId { get; set; }
			public Waluta WalutaDo { get; set; }

			public int ZrodloId { get; set; }
			public ZrodloKursu Zrodlo { get; set; }

			public decimal Kurs { get; set; }
			public DateTime Data { get; set; }

	}
}
