
using interfacePersona;

namespace clasePersona;
public class Persona: IPersona{
    
    //Atributos
    public string nombre { get; set; }
    public string apellido { get; set; }
    public int dni { get; set; }

    
    //Estructura de datos - atributos
    private List<String> amigos = new List<String>();
    
    
    //Constructor clase persona
    public Persona(string nombre, string apellido1, int dni)
    {
        this.nombre = nombre;
        this.apellido = apellido1;
        this.dni = dni;
    }
    
    //Sobrecarga constructor vacio
    public Persona(){}

    
    //Metodos
   
    public virtual void Saludar(){
        Console.WriteLine("Hola ,soy "+ nombre);
    }

    public void agregarAmigo(string nombre)
    {
        amigos.Add(nombre);
    }

    
    public void mostrarAmigos()
    {
        Console.WriteLine("Mis amigos son:");
        foreach (var amigo in amigos)
        {   
            Console.WriteLine(amigo);
        }
    }

    
}

