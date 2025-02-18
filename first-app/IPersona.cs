namespace interfacePersona;

public interface IPersona
{
    String nombre { get; set; }
    String apellido { get; set; }
    int dni { get; set; }


    public void Saludar();


}