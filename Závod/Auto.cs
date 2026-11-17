namespace ZavodAut
{
    public class Auto
    {
        public string Nazov { get; set; }
        public double Rychlost { get; set; }
        public double VelkostNadrze { get; set; }
        public double Spotreba { get; set; }
        public double AktualnePalivo { get; set; }
        public double CasKola { get; set; }
        public double CelkovyCas { get; set; }
        public bool MaPalivo { get; set; }

        public Auto(string nazov, double rychlost, double velkostNadrze, double spotreba)
        {
            Nazov = nazov;
            Rychlost = rychlost;
            VelkostNadrze = velkostNadrze;
            Spotreba = spotreba;
            AktualnePalivo = velkostNadrze;
            CelkovyCas = 0;
            MaPalivo = true;
        }

        internal void OdjazdiKolo(double dlzkaTrate)
        {
            if (!MaPalivo)
            {
                return;
            }

            double potrebnePalivo = (Spotreba / 100.0) * dlzkaTrate;

            if (AktualnePalivo < potrebnePalivo)
            {
                AktualnePalivo = 0;
                MaPalivo = false;
                CasKola = -1;
            }
            else
            {
                AktualnePalivo -= potrebnePalivo;
                CasKola = (dlzkaTrate / Rychlost) * 60.0;
                CelkovyCas += CasKola;
            }
        }
    }
}
