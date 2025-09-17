//using NUnit.Framework;
//using OE.ALGA.Optimalizalas;

//namespace OE.ALGA.Tesztek.Optimalizalas
//{
//    [TestFixture(Category = "Optimalizalas", TestName = "09 - Visszalépéses Keresés Tesztek")]
//    public class VisszalepesesKeresesTesztek
//    {
//        [TestCase]
//        public void JegyzetbenLevoPeldaErtekTeszt()
//        {
//            HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.jegyzet_n, PakolasTesztEsetek.jegyzet_Wmax, PakolasTesztEsetek.jegyzet_w, PakolasTesztEsetek.jegyzet_p);
//            VisszalepesesHatizsakPakolas opt = new VisszalepesesHatizsakPakolas(problema);
//            Assert.Multiple(() =>
//            {
//                Assert.That(opt.OptimalisErtek(), Is.EqualTo(PakolasTesztEsetek.jegyzet_optimalis_ertek));
//                Assert.That(opt.LepesSzam, Is.EqualTo(98));
//            });
//        }
//        [TestCase]
//        public void JegyzetbenLevoPeldaMegoldasTeszt()
//        {
//            HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.jegyzet_n, PakolasTesztEsetek.jegyzet_Wmax, PakolasTesztEsetek.jegyzet_w, PakolasTesztEsetek.jegyzet_p);
//            VisszalepesesHatizsakPakolas opt = new VisszalepesesHatizsakPakolas(problema);
//            Assert.Multiple(() =>
//            {
//                Assert.That(opt.OptimalisMegoldas(), Is.EquivalentTo(PakolasTesztEsetek.jegyzet_optimalis_pakolas));
//                Assert.That(opt.LepesSzam, Is.EqualTo(98));
//            });
//        }
//        [TestCase]
//        public void NagyPeldaMegoldasTeszt()
//        {
//            HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.nagy_n, PakolasTesztEsetek.nagy_Wmax, PakolasTesztEsetek.nagy_w, PakolasTesztEsetek.nagy_p);
//            VisszalepesesHatizsakPakolas opt = new VisszalepesesHatizsakPakolas(problema);
//            Assert.Multiple(() =>
//            {
//                Assert.That(opt.OptimalisErtek(), Is.EqualTo(PakolasTesztEsetek.nagy_optimalis_ertek));
//                Assert.That(opt.LepesSzam, Is.EqualTo(4832));
//            });
//        }
//        [TestCase]
//        public void LepesszamVizsgalat()
//        {
//            HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.nagy_n, PakolasTesztEsetek.nagy_Wmax, PakolasTesztEsetek.nagy_w, PakolasTesztEsetek.nagy_p);
//            VisszalepesesHatizsakPakolas opt = new VisszalepesesHatizsakPakolas(problema);
//            Assert.Multiple(() =>
//            {
//                Assert.That(opt.OptimalisErtek(), Is.EqualTo(PakolasTesztEsetek.nagy_optimalis_ertek));
//                Assert.That(opt.LepesSzam, Is.EqualTo(4832));
//            });
//        }
//    }

//    [TestFixture(Category = "Optimalizalas", TestName = "09 - Szétválasztás és Korlátozás Tesztek")]
//    public class SzetvalasztasEsKorlatozasTesztek
//    {
//        [TestCase]
//        public void JegyzetbenLevoPeldaErtekTeszt()
//        {
//            HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.jegyzet_n, PakolasTesztEsetek.jegyzet_Wmax, PakolasTesztEsetek.jegyzet_w, PakolasTesztEsetek.jegyzet_p);
//            SzetvalasztasEsKorlatozasHatizsakPakolas opt = new SzetvalasztasEsKorlatozasHatizsakPakolas(problema);
//            Assert.Multiple(() =>
//            {
//                Assert.That(opt.OptimalisErtek(), Is.EqualTo(PakolasTesztEsetek.jegyzet_optimalis_ertek));
//                Assert.That(opt.LepesSzam, Is.EqualTo(62));
//            });
//        }
//        [TestCase]
//        public void JegyzetbenLevoPeldaMegoldasTeszt()
//        {
//            HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.jegyzet_n, PakolasTesztEsetek.jegyzet_Wmax, PakolasTesztEsetek.jegyzet_w, PakolasTesztEsetek.jegyzet_p);
//            SzetvalasztasEsKorlatozasHatizsakPakolas opt = new SzetvalasztasEsKorlatozasHatizsakPakolas(problema);
//            Assert.Multiple(() =>
//            {
//                Assert.That(opt.OptimalisMegoldas(), Is.EquivalentTo(PakolasTesztEsetek.jegyzet_optimalis_pakolas));
//                Assert.That(opt.LepesSzam, Is.EqualTo(62));
//            });
//        }
//        [TestCase]
//        public void NagyPeldaMegoldasTeszt()
//        {
//            HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.nagy_n, PakolasTesztEsetek.nagy_Wmax, PakolasTesztEsetek.nagy_w, PakolasTesztEsetek.nagy_p);
//            SzetvalasztasEsKorlatozasHatizsakPakolas opt = new SzetvalasztasEsKorlatozasHatizsakPakolas(problema);
//            Assert.Multiple(() =>
//            {
//                Assert.That(opt.OptimalisErtek(), Is.EqualTo(PakolasTesztEsetek.nagy_optimalis_ertek));
//                Assert.That(opt.LepesSzam, Is.EqualTo(618));
//            });
//        }
//        [TestCase]
//        public void LepesszamVizsgalat()
//        {
//            HatizsakProblema problema = new HatizsakProblema(PakolasTesztEsetek.nagy_n, PakolasTesztEsetek.nagy_Wmax, PakolasTesztEsetek.nagy_w, PakolasTesztEsetek.nagy_p);
//            SzetvalasztasEsKorlatozasHatizsakPakolas opt = new SzetvalasztasEsKorlatozasHatizsakPakolas(problema);
//            Assert.Multiple(() =>
//            {
//                Assert.That(opt.OptimalisErtek(), Is.EqualTo(PakolasTesztEsetek.nagy_optimalis_ertek));
//                Assert.That(opt.LepesSzam, Is.EqualTo(618));
//            });
//        }
//    }
//}
