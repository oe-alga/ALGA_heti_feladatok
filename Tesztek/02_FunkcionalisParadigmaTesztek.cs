//using NUnit.Framework;
//using OE.ALGA.Paradigmak;

//namespace OE.ALGA.Tesztek.Paradigmak
//{
//    [TestFixture(Category = "Paradigmák", TestName = "02 - Feltételes Feladat Tároló Tesztek")]
//    public class FeltetelesFeladatTaroloTesztek
//    {
//        [TestCase]
//        public void Felvesz()
//        {
//            FeltetelesFeladatTarolo<TesztFeladat> tarolo = new FeltetelesFeladatTarolo<TesztFeladat>(5);
//            TesztFeladat a = new TesztFeladat("a");
//            tarolo.Felvesz(a);
//            tarolo.Felvesz(a);
//            tarolo.Felvesz(a);
//        }
//        [TestCase]
//        public void TulsokatFelvesz()
//        {
//            FeltetelesFeladatTarolo<TesztFeladat> tarolo = new FeltetelesFeladatTarolo<TesztFeladat>(3);
//            TesztFeladat a = new TesztFeladat("a");
//            tarolo.Felvesz(a);
//            tarolo.Felvesz(a);
//            tarolo.Felvesz(a);
//            Assert.Throws<TaroloMegteltKivetel>(() => tarolo.Felvesz(a));
//        }
//        [TestCase]
//        public void NincsMitVegrehajtani()
//        {
//            FeltetelesFeladatTarolo<TesztFeladat> tarolo = new FeltetelesFeladatTarolo<TesztFeladat>(2);
//            tarolo.MindentVegrehajt();
//        }
//        [TestCase]
//        public void MindenVegrehajtas()
//        {
//            FeltetelesFeladatTarolo<TesztFeladat> tarolo = new FeltetelesFeladatTarolo<TesztFeladat>(2);
//            TesztFeladat a = new TesztFeladat("a");
//            TesztFeladat b = new TesztFeladat("b");
//            tarolo.Felvesz(a);
//            tarolo.Felvesz(b);
//            Assert.Multiple(() =>
//            {
//                Assert.That(a.Vegrehajtott, Is.False);
//                Assert.That(b.Vegrehajtott, Is.False);
//            });
//            tarolo.MindentVegrehajt();
//            Assert.Multiple(() =>
//            {
//                Assert.That(a.Vegrehajtott, Is.True);
//                Assert.That(b.Vegrehajtott, Is.True);
//            });
//        }
//        [TestCase]
//        public void FeltetelesVegrehajtas()
//        {
//            FeltetelesFeladatTarolo<TesztFeladat> tarolo = new FeltetelesFeladatTarolo<TesztFeladat>(10);
//            TesztFeladat a1 = new TesztFeladat("a1");
//            TesztFeladat b1 = new TesztFeladat("b1");
//            TesztFeladat a2 = new TesztFeladat("a2");
//            tarolo.Felvesz(a1);
//            tarolo.Felvesz(b1);
//            tarolo.Felvesz(a2);
//            Assert.Multiple(() =>
//            {
//                Assert.That(a1.Vegrehajtott, Is.False);
//                Assert.That(b1.Vegrehajtott, Is.False);
//                Assert.That(a2.Vegrehajtott, Is.False);
//            });
//            tarolo.FeltetelesVegrehajtas(x => { Guardian.Recursion.CheckStackTrace(); return x.Azonosito[0] == 'a'; }); // csak 'a' kezdetűek végrehajtása
//            Assert.Multiple(() =>
//            {
//                Assert.That(a1.Vegrehajtott, Is.True);
//                Assert.That(b1.Vegrehajtott, Is.False);
//                Assert.That(a2.Vegrehajtott, Is.True);
//            });
//            tarolo.FeltetelesVegrehajtas(x => { Guardian.Recursion.CheckStackTrace(); return x.Azonosito[0] == 'b'; }); // csak 'b' kezdetűek végrehajtása
//            Assert.Multiple(() =>
//            {
//                Assert.That(a1.Vegrehajtott, Is.True);
//                Assert.That(b1.Vegrehajtott, Is.True);
//                Assert.That(a2.Vegrehajtott, Is.True);
//            });
//        }
//        [TestCase]
//        public void FeltetelesFuggosegesVegrehajtas()
//        {
//            FeltetelesFeladatTarolo<TesztFuggoFeladat> tarolo = new FeltetelesFeladatTarolo<TesztFuggoFeladat>(10);
//            TesztFuggoFeladat a1 = new TesztFuggoFeladat("a1") { Vegrehajthato = true };
//            TesztFuggoFeladat b1 = new TesztFuggoFeladat("b1") { Vegrehajthato = true };
//            TesztFuggoFeladat a2 = new TesztFuggoFeladat("a2") { Vegrehajthato = false };
//            tarolo.Felvesz(a1);
//            tarolo.Felvesz(b1);
//            tarolo.Felvesz(a2);
//            Assert.Multiple(() =>
//            {
//                Assert.That(a1.Vegrehajtott, Is.False);
//                Assert.That(b1.Vegrehajtott, Is.False);
//                Assert.That(a2.Vegrehajtott, Is.False);
//            });
//            tarolo.FeltetelesVegrehajtas(x => { Guardian.Recursion.CheckStackTrace(); return x.Azonosito[0] == 'a' && x.FuggosegTeljesul; }); // csak 'a' kezdetű és végrehajtható
//            Assert.Multiple(() =>
//            {
//                Assert.That(a1.Vegrehajtott, Is.True);
//                Assert.That(b1.Vegrehajtott, Is.False);
//                Assert.That(a2.Vegrehajtott, Is.False);
//            });
//            tarolo.FeltetelesVegrehajtas(x => { Guardian.Recursion.CheckStackTrace(); return x.Azonosito[0] == 'b' && x.FuggosegTeljesul; }); // csak 'b' kezdetű és végrehajtható
//            Assert.Multiple(() =>
//            {
//                Assert.That(a1.Vegrehajtott, Is.True);
//                Assert.That(b1.Vegrehajtott, Is.True);
//                Assert.That(a2.Vegrehajtott, Is.False);
//            });
//            a2.Vegrehajthato = true;
//            tarolo.FeltetelesVegrehajtas(x => { Guardian.Recursion.CheckStackTrace(); return x.Azonosito[0] == 'a' && x.FuggosegTeljesul; }); // csak 'a' kezdetű és végrehajtható
//            Assert.Multiple(() =>
//            {
//                Assert.That(a1.Vegrehajtott, Is.True);
//                Assert.That(b1.Vegrehajtott, Is.True);
//                Assert.That(a2.Vegrehajtott, Is.True);
//            });
//        }
//        [TestCase]
//        public void Bejaro()
//        {
//            FeltetelesFeladatTarolo<TesztFeladat> tarolo = new FeltetelesFeladatTarolo<TesztFeladat>(10);
//            TesztFeladat a = new TesztFeladat("a");
//            TesztFeladat b = new TesztFeladat("b");
//            tarolo.Felvesz(a);
//            tarolo.Felvesz(b);
//            string nevek = "";
//            foreach (TesztFeladat u in tarolo)
//                nevek += u.Azonosito;
//            Assert.That(nevek, Is.EqualTo("ab"));
//        }
//        [TestCase]
//        public void FeltetelesBejaro()
//        {
//            FeltetelesFeladatTarolo<TesztFuggoFeladat> tarolo = new FeltetelesFeladatTarolo<TesztFuggoFeladat>(10);
//            tarolo.BejaroFeltetel = (x => { Guardian.Recursion.CheckStackTrace(); return x.FuggosegTeljesul; });
//            TesztFuggoFeladat a = new TesztFuggoFeladat("a") { Vegrehajthato = true };
//            TesztFuggoFeladat b = new TesztFuggoFeladat("b") { Vegrehajthato = false };
//            TesztFuggoFeladat c = new TesztFuggoFeladat("c") { Vegrehajthato = true };
//            tarolo.Felvesz(a);
//            tarolo.Felvesz(b);
//            tarolo.Felvesz(c);
//            string nevek = "";
//            foreach (TesztFeladat u in tarolo)
//                nevek += u.Azonosito;
//            Assert.That(nevek, Is.EqualTo("ac"));
//        }
//    }
//}
