using tareaT8;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Tarea> pendientes = new List<Tarea>();
        List<Tarea> realizadas = new List<Tarea>();
        string[] arrependientes ={"limpiar banios", "limpiar gondolas", "Reponer jabones", "limpiar pasillos", "labar platos",
        "reponer fiambres","limpiar cajas", "Reponer cajas","cambiar lacteos", "etiquetar promociones"
        ," cambiar focos ","cambiar letreros" , "nada ahre"};
        int opcion = 1;
        string? textNum = " ", busquedaDescripcion = " ";
        int cantPendientes = 10;
        int cantRealizadas = 0;
        Tarea Tarea = new Tarea();
        cargarTareas(pendientes, cantPendientes);

        do
        {
            Console.WriteLine("************* DISTRIBUIDORA **************\n");
            Console.WriteLine("\n\t (1)Mostrar tareas");
            Console.WriteLine("\n\t (2)Mover Tareas");
            Console.WriteLine("\n\t (3)Buscar tareas");
            Console.WriteLine("\n\t (4)Salir\n");
            Console.WriteLine("******************************************\n");
            textNum = Console.ReadLine();
            int.TryParse(textNum, out opcion);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\t\n************* Tareas Pendientes ***********\n");
                    mostrarTareas(pendientes, cantPendientes);
                    Console.WriteLine("\t\n************* Tareas Realizadas ***********\n");
                    cantRealizadas = realizadas.Count;
                    mostrarTareas(realizadas, cantRealizadas);
                    break;
                case 2:
                    moverTarea(pendientes, ref cantPendientes);
                    break;
                case 3:
                    Console.WriteLine("Ingrese una descripcion\n");
                    busquedaDescripcion = Console.ReadLine();

                    Tarea = buscarTareas(pendientes, busquedaDescripcion);
                    if(Tarea.Descripcion==null) Tarea = buscarTareas(realizadas, busquedaDescripcion);

                    if (Tarea.Descripcion != null)
                    {
                        Console.WriteLine("\n¡Tarea Encontrada!");
                        Console.WriteLine("Descripcion: " + Tarea.Descripcion);
                        Console.WriteLine("Id: " + Tarea.Id);
                        Console.WriteLine("Duracion: " + Tarea.Duracion + "\n");
                    } else Console.WriteLine("¡ Tarea no encontrada !");
                    break;
            }

        } while (opcion != 4);






        void mostrarTareas(List<Tarea> tareas, int cantN)

        {
            for (int i = 0; i < cantN; i++)
            {
                Console.WriteLine("TAREA N " + i);
                Console.WriteLine("Descripcion: " + tareas[i].Descripcion);
                Console.WriteLine("Id: " + tareas[i].Id);
                Console.WriteLine("Duracion: " + tareas[i].Duracion + "\n");
            }
        }

        void moverTarea(List<Tarea> tareas, ref int cant)
        {
            int option = 1, id;
            string? textNum;

            Console.WriteLine("\t******* Mover tareas ******\n");
            do
            {
                mostrarTareas(tareas, cant);
                Console.WriteLine("ingrese un Id para mover\n");
                textNum = Console.ReadLine();
                int.TryParse(textNum, out id);
                var tarea = pendientes.Find(Especifica => Especifica.Id == id);

                if (tarea != null)
                {
                    realizadas.Add(tarea);
                    pendientes.Remove(tarea);
                    cant = tareas.Count;
                    Console.WriteLine("¡Movimiento Exitoso !\n");
                }
                else Console.WriteLine("¡id no encontrado!\n");

                Console.WriteLine("¿ desea seguir moviendo tareas?\n");
                textNum = Console.ReadLine();
                int.TryParse(textNum, out option);
            } while (option == 1);


        }

        void cargarTareas(List<Tarea> tareas, int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Random Ntarea = new Random();
                Random NDuracion = new Random();
                int DuracionAlt = NDuracion.Next(30, 120);
                int TareaAlt = Ntarea.Next(0, 6);
                var NuevaTarea = new Tarea()
                {
                    Id = i + 1,
                    Descripcion = arrependientes[TareaAlt],
                    Duracion = DuracionAlt,
                };
                pendientes.Add(NuevaTarea);
            }

        }

        Tarea buscarTareas(List<Tarea> tareas, string descripcion)
        {
            Tarea Retorno = new Tarea();
            foreach (var tareita in tareas)
            {
                if (tareita.Descripcion == descripcion)
                {
                    Retorno = tareita;
                    return Retorno;
                }
            }

            return Retorno;
        }

    }
}
/*static Program mostrarTareas ()
{

}*/
// var realizadas = new Lista<Tarea>;

/*var tarea1 = new Tarea(){
    Id=12,
    Descripcion= "limpiar banios",
    Duracion = 30,
};

var Tarea2= new Tarea (){
    Id = 4,
    Descripcion=" labar platos",
    Duracion = 40,
};

Console.WriteLine("Descripcion="+tarea1.Descripcion);
Console.WriteLine("duracion="+tarea1.Duracion);
Console.WriteLine("Id="+tarea1.Id);
pendientes.Add(tarea1); //añado una tarea a pendientes 
pendientes.Add(Tarea2); // añado otra tarea a pendientes

var Tarea3= pendientes [1]; // cargo la tarea 3 con lo que tiene la tarea 2 (que está en la posicion 1 de la lista)
var tarea4= pendientes.Find(t => t.Id ==3); // (t) puede tener cualquier nombre 
pendientes.Remove(Tarea3); // borro la tarea 3
pendientes.RemoveAt(1); //borro la tarea en la posicion 1

for (int i=0; i < pendientes.lendt , i++)
{
    int si =consorele.Read();
    if (si==1)
    {
        //var tarea = pendiente [i];
        realizadas.Add(item);
        //pendinetes.remove(item)
    }
    
}


foreach (var item in realizadas)
{
    pendientes.Remove(item);
}


var archivo = new StreamWriter ("archivo")

*/

