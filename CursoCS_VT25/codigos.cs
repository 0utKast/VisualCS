

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















































