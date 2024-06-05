using NUnit.Framework;
using DolgozatProjekt;

namespace DolgozatProject.Tests
{
	[TestFixture]
	public class DolgozatTests
	{
		private Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[TestCase]
		public void PontFelvesz_ErvenyesPontszam_Hozzaadodik()
		{
			dolgozat.PontFelvesz(75);
			Assert.Contains(75, dolgozat.Pontok);
		}

		[TestCase]
		public void PontFelvesz_ErvenytelenPontszam_KiveteltDob()
		{
			Assert.Throws<ArgumentException>(() => dolgozat.PontFelvesz(101));
		}

		[TestCase]
		public void MindenkiMegirta_MindenkiMegirtaIgaz()
		{
			dolgozat.PontFelvesz(50);
			dolgozat.PontFelvesz(75);
			Assert.IsTrue(dolgozat.MindenkiMegirta);
		}

		[TestCase]
		public void MindenkiMegirta_VanAkiNemIrtaMegHamis()
		{
			dolgozat.PontFelvesz(50);
			dolgozat.PontFelvesz(-1);
			Assert.IsFalse(dolgozat.MindenkiMegirta);
		}
	}
}