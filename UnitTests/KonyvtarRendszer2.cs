using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Konyvtar_Kezeles_Rendszer;

namespace UnitTests
{
    public class KonyvtarRendszerTests2
    {
        [Fact]
        public void KiadKonyv()
        {
            var konyvtarRendszer = new KonyvtarRendszer();
            var konyv = new KonyvekKiadasa { ID = 1, KonyvCime = "Harry Potter" };
            konyvtarRendszer.KiadKonyv(konyv);

            Assert.Contains(konyv, konyvtarRendszer.GetKiadottKonyvek(), k => k.KonyvCime == konyv.KonyvCime);
        }

        [Fact]
        public void VisszaKonyv()
        {
            var konyvtarRendszer = new KonyvtarRendszer();
            var konyv = new VisszahozottKonyvek { ID = 1, KonyvCime = "Harry Potter" };
            var observerMock = new Mock<IObserver>();
            konyvtarRendszer.HozzaadObserver(observerMock.Object);
            konyvtarRendszer.VisszaKonyv(konyv);

            Assert.Contains(konyv, konyvtarRendszer.GetVisszahozottKonyvek());
            observerMock.Verify(o => o.Update("Könyv visszavétele:" + KonyvCime = "Harry Potter"), Times.Once);
        }