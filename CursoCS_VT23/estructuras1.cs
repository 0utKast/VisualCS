/*struct Tiempo
{
    public int horas, minutos, segundos;
}*/

struct Tiempo
{
    private int horas, minutos, segundos;
    ...
    public Tiempo(int hh, int mm, int ss)
    {
        this.horas = hh % 24;
        this.minutos = mm % 60;
        this.segundos = ss % 60;
    }

      public int Horas()
    {
        return this.horas;
    }
 }

 
