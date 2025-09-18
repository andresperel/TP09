using Newtonsoft.Json;
public class Usuario
{
   string nombre;
   public int cantidadDeIntentos;
   public Usuario(string pNombre, int pCantidadDeIntentos){
    nombre=pNombre;
    cantidadDeIntentos=pCantidadDeIntentos;
   }
}
