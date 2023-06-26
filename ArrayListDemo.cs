using System.Collections;
public class ArrayListDemo {
    //definimos el ArrayList
    ArrayList estudiantes = new ArrayList();

    public ArrayList Estudiantes { get => estudiantes; set => estudiantes = value; }

    //creacion de los metodos, se clasifican en dos Tipos
    //funcionales que retornan valor
    //no funcionales los que no retornan ningun valor

    //procedimiento para agregar elementos
    //el (dato) contiene el valor o elemento que se va a almacenar en el array List
    public void AddElement(string dato) {
        this.Estudiantes.Add(dato);
    }

    public ArrayList viewElement(){
        return this.Estudiantes;
    }

    public bool validarContenido(string dato){
        return this.Estudiantes.Contains(dato);
    }

     public int IdxElemento(string dato){
        return this.Estudiantes.IndexOf(dato);
    }


}