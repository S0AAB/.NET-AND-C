using clasePersona;
using claseEstudiante;
class Program {

    // Main Method
    static void Main(string[] args)
    {
        Persona persona1 = new Persona("Carlitos","Guevara",123454);

        /*persona1.Saludar();
        persona1.agregarAmigo("Santiago");
        persona1.agregarAmigo("Martina");
        persona1.mostrarAmigos();*/
        
        Estudiante estudiante1 = new Estudiante(123121,"sexto","Alejandra","Gomez",12154);
        
        estudiante1.Saludar();
       
    }
}