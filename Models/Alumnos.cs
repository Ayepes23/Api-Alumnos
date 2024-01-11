namespace MyApi.Models;

public class Alumnos
{
    public long Id { get; set; }
    public string? DNI { get; set; }
    public string? Nombre { get; set; }
    public string? Apellidos { get; set; }
    public string? Direccion { get; set; }
    public int? CP { get; set; }
    public string? Ciudad { get; set; }
    public int? Telefono { get; set; }
    public string? Email { get; set; }

}