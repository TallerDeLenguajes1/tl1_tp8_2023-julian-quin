internal class Program
{
    private static void Main(string[] args)
    {
        string? path;
        Console.WriteLine("ingrese la direccion de una carpeta");
        path = Console.ReadLine();
        if (Directory.Exists(path))
        {
            string[] archivos = Directory.GetFiles(path);
            foreach (var archivo in archivos)
            {
                Console.WriteLine(archivo);
            }

            String NombreArchivo;
            String Extencion;
            string ArchivoCSV = "index.csv";
            using (StreamWriter intanciaSW_CVS = new StreamWriter(ArchivoCSV))
            {
                for (int i = 0; i < archivos.Length; i++)
                {
                    NombreArchivo = Path.GetFileNameWithoutExtension(archivos[i]);
                    Extencion = Path.GetExtension(archivos[i]);
                    string armado = (i+1) + "," + NombreArchivo + "," + Extencion;
                    intanciaSW_CVS.WriteLine(armado);
                }
            }



        }
        else Console.WriteLine("El path no es valido");



    }

}

