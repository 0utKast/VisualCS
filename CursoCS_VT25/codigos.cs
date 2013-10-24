

int []ids =new int[4] {1,3,5,7}


Random r = new Random();
int[] ids = new int[4]{ r.Next() % 10, r.Next() % 10,
	                    r.Next() % 10, r.Next() % 10 };


int[] ids = new int[3]{ 1, 3, 5, 7 }; // error en tiempo de compilación
int[] ids = new int[4]{ 1, 3, 5 };    // error en tiempo de compilación
int[] ids = new int[4]{ 1, 3, 5, 7 }; // Correcto

int[] ids = { 1, 3, 5, 7 };

Hora[] agenda = {new Hora(7,25), new Hora(8,10)};

var nombres = new[]{"Ringo", "George", "John", "Paul"};

var nombres = new[]{"Ringo", "George", 1960, 1970}; /*Excepción "No best type found
                                                      for implicitly typed array"*/



var nombres = new[] { new { Nombre = "Juan", Edad = 17 },
                    new { Nombre = "Rosa", Edad = 26 },
                    new { Nombre = "Javier", Edad = 20 },
                    new { Nombre = "María", Edad = 28 } };

                    foreach (var miembroFamilia in nombres)
{
    Console.WriteLine("Nombre: {0}, Edad: {1}", miembroFamilia.Nombre, miembroFamilia.Edad);
}




int[] ids = new int[4]{ 1, 3, 5, 7 };


int verId;
verId = ids[2]



verId = 9;
ids[2] =verId;


try
{
    int[] ids = { 1, 3, 5, 7 };
    Console.WriteLine(ids[4]); // error, el cuarto elemento y último es el index 3
}
catch (IndexOutOfRangeException ex)
{
    ...
}


int[] ids = { 1, 3, 5, 7 };
for (int index = 0; index < ids.Length; index++)
{
    int id = ids[index];
    Console.WriteLine(id);
}

int[] ids = { 1, 3, 5, 7 };
foreach (int id in ids)
{
    Console.WriteLine(id);
}

1) Una declaración foreach siempre se itera a través de todo el array

2) Si el cuerpo necesita saber el index del elemento y no sólo su valor

3) Si necesitamos modificar los elementos del array




PASAR ARRAYS COMO PARÁMETROS Y DEVOLVER VALORES PARA UN MÉTODO.

public void procesoDatos(int[] datos)
{
    foreach (int dato in datos)
    {
        ...
    }
}


//Los Arrays son objetos referencia



//Ejemplo de un método que tiene un array como valor de retorno.

public int[] LeerDatos()
{
    Console.WriteLine("¿Cuántos elementos?");
    string replica = Console.ReadLine();
    int numElementos = int.Parse(replica);

    int[] datos = new int[numElementos];
    for (int i = 0; i < numElements; i++)
    {
        Console.WriteLine("Escribe datos para el elemento {0}", i);
        replica = Console.ReadLine();
        int datosElemento = int.Parse(replica);
        datos[i] = datosElemento;
    }
    return datos;
}


int[] datos = Leerdatos();



static void Main(string[] args)
{
    ...
}


static void Main(string[] args)
{
    foreach (string filename in args)
    {
        ProcessFile(filename);
    }
}
 

MyFileUtil C:\Temp\TestData.dat C:\Users\Jesus\Documents\MiDoc.txt


COPIA DE ARRAYS
	
	
	
	


































































