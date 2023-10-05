using Domain;

namespace MyCars.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //Given when then
        //Arrange Act Assert

        [TestMethod]
        public void Given_MarqueValide_PrixValide_ModeleValide_When_AppelConstructeurVoiture_Then_InstanciationOK()
        {
            int price = 7500;
            string brand = "renault";
            string model = "megane";
            Voiture maVoiture = new Voiture(price, brand, model);

            Assert.IsTrue(maVoiture.Prix == price, "Le prix n'est pas conforme au prix attendu");
            Assert.IsTrue(maVoiture.Marque.Equals(brand), "La marque n'est pas la marque attendu");
            Assert.IsTrue(maVoiture.Modele.Equals(model), "Le model n'est pas le model attendu");
        }

        [TestMethod]
        public void Given_MarqueValide_PrixTropBas_ModeleValide_When_AppelConstructeurVoiture_Then_ArgumentOutOfRangeExceptionLeve()
        {
            int price = 2500;
            string brand = "renault";
            string model = "megane";
            Voiture voiture;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => voiture = new Voiture(price, brand, model), "L'instanciation n'a pas soulever d' ArgumentOutOfRangeException malgrès un prix trop bas");
        }

        [TestMethod]
        public void Given_MarqueValide_PrixTropHaut_ModeleValide_When_AppelConstructeurVoiture_Then_ArgumentOutOfRangeExceptionLeve()
        {
            int price = 2000500;
            string brand = "renault";
            string model = "megane";
            Voiture voiture;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => voiture = new Voiture(price, brand, model), "L'instanciation n'a pas soulever d' ArgumentOutOfRangeException malgrès un prix trop haut");
        }

        [TestMethod]
        public void Given_MarqueFaux_PrixValide_ModeleValide_When_AppelConstructeurVoiture_Then_ArgumentExceptionLeve()
        {
            int price = 7500;
            string brand = "ren";
            string model = "megane";
            Voiture voiture;

            Assert.ThrowsException<ArgumentException>(() => voiture = new Voiture(price, brand, model), "L'instanciation n'a pas soulever d' ArgumentException malgrès un prix trop bas");
        }

        [TestMethod]
        public void Given_MarqueValide_PrixValide_ModeleFaux_When_AppelConstructeurVoiture_Then_ArgumentExceptionLeve()
        {
            int price = 7500;
            string brand = "renault";
            string model = "t";
            Voiture voiture;

            Assert.ThrowsException<ArgumentException>(() => voiture = new Voiture(price, brand, model), "L'instanciation n'a pas soulever d' ArgumentException malgrès un prix trop bas");
        }


    }
}