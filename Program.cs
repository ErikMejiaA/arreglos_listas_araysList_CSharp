using arreglos_listas_araysList_CSharp;
internal class Program
{
    private static void Main(string[] args)
    {
        //Arreglos primitivos en C# Sharp

        Arreglos arreglosObj = new Arreglos();
        arreglosObj.nombres[0] = "Mario";
        arreglosObj.nombres[1] = "Jose";
        arreglosObj.nombres[2] = "Manuel";
        arreglosObj.nombres[3] = "Ana";

        //para mostrar el contenido
        Console.WriteLine(arreglosObj.nombres[0]);

        Console.Clear();
        //El metodo (Length) me permite determinar la cantidad de elementos que tiene un arreglo
        Console.WriteLine($"El total de elementos del Arreglo es: {arreglosObj.nombres.Length}");

        Console.ReadKey();
        //para mostrar todo el contenido 
        foreach (string item in arreglosObj.nombres)
        {
            Console.WriteLine(item);
        }

        //para ordenar un Arreglo se utiliza
        Array.Sort(arreglosObj.nombres);
        foreach (string item in arreglosObj.nombres)
        {
            Console.WriteLine(item);
        }

        //---------------------- ArrayList +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //los arreglos creados manualmente no nesesitan de una namespace

        ArrayListDemo lstEstudiantes = new ArrayListDemo();
        //para ingresar mas de un estudiante
        for (int i = 0; i < 2; i++)
        {
             Console.WriteLine("Ingrese un Estudiante: ");
            lstEstudiantes.AddElement(Console.ReadLine());     
        }
       
        //viewElement retorna un valor
        foreach(string estudiantes in lstEstudiantes.viewElement()){
            Console.WriteLine(estudiantes);
        }

        //borrar los elementos de una array List se utiliza el clear
        //lstEstudiantes.Estudiantes.Clear();

        //el (Count) nos permite obtener la cantidad de elementos que contiene un ArrayList
        Console.WriteLine($"El total de elementos en el ArrayList es de: {lstEstudiantes.Estudiantes.Count}");

        //buscar elemtos dentro de un ArrayList (Contains)

        Console.WriteLine("Dijite el nombre a buscar: ");
        Console.WriteLine(lstEstudiantes.validarContenido(Console.ReadLine()) ? "El estudiante fue encontrado" : "No se encontro el estudiante");

        //buscar el indice del elemento dentro del ArrayList se implementa el elemento (IndexOf)
        Console.WriteLine("Dijite el nombre a buscar: ");
        Console.WriteLine($"El estudiante esta en la posicion: {lstEstudiantes.IdxElemento(Console.ReadLine())}");

    }
}