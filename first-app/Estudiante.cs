using clasePersona;

namespace claseEstudiante;

public class Estudiante:Persona
{   
    
    //Atributos
    private long identificador;
    private string grado;
    
    
    //Getter y setter
    public long Identificador {get ; set; }
    public string Grado {get ; set; }
    
    
    //Contructores

    public Estudiante(long identificador, string grado, string nombre, string apellido1, int dni) 
        : base(nombre, apellido1, dni) // Llamamos al constructor de Persona
    {
        this.identificador = identificador;
        this.grado = grado;
    }


    public Estudiante(){}
    
    //Sobreescritura metodo de clase padre

    public override void Saludar()
    {
        Console.WriteLine("Estudiante Saludando con numero: "+ identificador);
    }
    
    //Sobrecarga petodo Saludar()

    public void Saludar(String mensaje)
    {
        base.Saludar();
        Console.WriteLine(mensaje);
    }
    
    
    
    
}