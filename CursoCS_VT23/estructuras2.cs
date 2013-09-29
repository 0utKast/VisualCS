/* Podemos crear constructors no por defecto, pero deben 
EXPLÍCITAMENTE INICIAR todos los campos de nuestra estructura*/


struct Tiempo
{
    private int horas, minutos, segundos;
    ...
    public Tiempo(int hh, int mm)
    {
        this.horas = hh;
        this.minutos = mm;
    }   /* error en tiempo de compilación: segundos no inicializado (si fuera una clase
    	si funcionaría)*/
}


