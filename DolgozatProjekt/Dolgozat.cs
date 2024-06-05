namespace DolgozatProjekt
{
	public class Dolgozat
	{
		public List<int> Pontok { get; private set; }

		public Dolgozat()
		{
			Pontok = new List<int>();
		}

		public void PontFelvesz(int x)
		{
			if (x < -1 || x > 100)
			{
				throw new ArgumentException("Érvénytelen pontszám. A pontszámnak -1 és 100 között kell lennie.");
			}
			Pontok.Add(x);
		}

		public bool MindenkiMegirta
		{
			get { return !Pontok.Contains(-1); }
		}

		public int Bukas
		{
			get { return Pontok.Count(p => p >= 0 && p < 50); }
		}

		public int Elegseges
		{
			get { return Pontok.Count(p => p >= 50 && p <= 60); }
		}

		public int Kozepes
		{
			get { return Pontok.Count(p => p >= 61 && p <= 70); }
		}

		public int Jo
		{
			get { return Pontok.Count(p => p >= 71 && p <= 80); }
		}

		public int Jeles
		{
			get { return Pontok.Count(p => p > 81); }
		}

		public bool Gyanus(int kivalok)
		{
			if (kivalok < 0)
			{
				throw new ArgumentException("A kiváló tanulók száma nem lehet negatív.");
			}
			return Jeles > kivalok;
		}

		public bool Ervenytelen
		{
			get
			{
				int diakokSzama = Pontok.Count;
				int nemIrtakSzama = Pontok.Count(p => p == -1);
				return nemIrtakSzama >= diakokSzama / 2;
			}
		}
	}
}