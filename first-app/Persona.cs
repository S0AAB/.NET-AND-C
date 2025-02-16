namespace clasePersona;
public class Person{
    private String nombre="nombreDefault";
    private String apellido1="apellidoDefault";
    private int dni=212;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido1 { get => apellido1; set => apellido1 = value; }
    public int Dni { get => dni; set => dni = value; }

    public Person(string nombre, string apellido1, int dni)
    {
        this.Nombre = nombre;
        this.Apellido1 = apellido1;
        this.Dni = dni;
    }

    public Person(){}

    public void Saludar(){
        Console.Write("Hola ,soy "+ nombre);
    }

    
}

