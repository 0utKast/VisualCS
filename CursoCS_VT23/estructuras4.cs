/* Declarar variables estructura*/


struct Tiempo
{
    private int horas, minutos, segundos;
    ...
}

class Ejemplo
{
    private Tiempo horaActual;

    public void Metodo(Tiempo parametro)
    {
        Tiempo variableLocal;
        ...
    }
}

//Podemos crear versión nullable de variables estructura con modificador "?"
Tiempo?horaActual = null: