class Circulo
{
    private int radio;
    public static int NumCirculos = 0;

    public Circulo()  // constructor por defecto
    {
        radio = 0;
        NumCirculos++;
    }

    public Circulo(int radioInicial) // constructor sobrecargado
    {
        radio = radioInicial;
        NumCirculos++;
    }
}












