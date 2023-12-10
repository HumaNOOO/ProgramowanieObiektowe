namespace CwiczeniaLista1
{
    class Car
    {
        public Car(int rokProdukcji, String marka)
        {
            if (rokProdukcji > 1769 && rokProdukcji < 2024)
            {
                this.rokProdukcji = rokProdukcji;
            }
            else
            {
                this.rokProdukcji = 2000;
            }
            this.marka = marka;
            model = "none";
            iloscDrzwi = 5;
            pojemnoscSilnika = 1;
            srednieSpalanie = 1;
        }

        public Car(int rokProdukcji, String marka, String model, int iloscDrzwi, double pojemnoscSilnika, double srednieSpalanie)
        {
            if (rokProdukcji > 1769 && rokProdukcji < 2024)
            {
                this.rokProdukcji = rokProdukcji;
            }
            else
            {
                this.rokProdukcji = 2000;
            }
            this.marka = marka;
            this.model = model;
            this.iloscDrzwi = iloscDrzwi;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.srednieSpalanie = srednieSpalanie;
        }

        public int PobierzRokProdukcji()
        {
            return this.rokProdukcji;
        }

        public String PobierzMarke()
        {
            return this.marka;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return srednieSpalanie * dlugoscTrasy;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

        private int rokProdukcji;
        private String marka;
        private String model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;
    }
}
