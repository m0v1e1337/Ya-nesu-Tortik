namespace PractosNumber5
{
    public class Cake
    {
        public int shape;
        public string forma;
        public string razmer;
        public string vkus;
        public string Korgey;
        public string glazurka;
        public string decor;
        public Cake(int Paramshape, string ParamForma, string ParamSize, string Paramvkus, string ParamKorgey, string Paramglazurka, string ParamDecor)
        {
            shape = Paramshape;
            forma = ParamForma;
            razmer = ParamSize;
            vkus = Paramvkus;
            Korgey = ParamKorgey;
            glazurka = Paramglazurka;
            decor = ParamDecor;
        }
    }
}