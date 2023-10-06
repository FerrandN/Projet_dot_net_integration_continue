namespace Domain
{
    public class Voiture
    {
        private int prix;
        private string marque;
        private string modele;

        private static int MIN_PRICE = 5000;
        private static int MAX_PRICE = 500000;

        public string Modele { get => modele; private set => ChangerModele(value); }
        public string Marque { get => marque; private set => ChangerMarque(value); }

        public int Prix { get => prix; set => ChangerPrix(value); }

        public Voiture(int _prix, string _marque, string _modele)
        {
            this.Prix = _prix;
            this.Marque = _marque;
            this.Modele = _marque;
        }

        private void ChangerMarque(string _marque)
        {
            if (!IsLengthOk(_marque, 4))
            {
                throw new ArgumentException("Marque invalide");
            }
            marque = _marque;

        }


        private void ChangerModele(string _modele)
        {
            if (!IsLengthOk(_modele, 2))
            {
                throw new ArgumentException("Modele invalide");
            }
            modele = _modele;
        }

        private void ChangerPrix(int _prix)
        {
            if (_prix < MIN_PRICE || _prix > MAX_PRICE)
            {
                throw new ArgumentOutOfRangeException("Le prix du vehicule est invalide");
            }
            prix = _prix;
        }

        private static bool IsLengthOk(string str, int length)
        {
            return str!= null && str.Length >= length;
        }
    }
}