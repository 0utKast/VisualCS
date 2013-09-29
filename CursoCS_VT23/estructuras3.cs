/* En una estructura no podemos inicializar campos instancia en su punto
de declaración*/


struct Tiempo
{
    private int horas = 0; // error en tiempo de compilación
    private int minutos;
    private int segundos;
    ...
}


