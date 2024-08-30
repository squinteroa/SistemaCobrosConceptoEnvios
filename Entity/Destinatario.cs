using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Destinatario : Cliente
    {
        public string Compania { get; set; }
        public string Direccion { get; protected set; }
        public Destinatario(string nombre, string telefono, string compania) : base(nombre, telefono)
        {
            //this.Nombre = nombre;
            //this.Telefono = telefono;
            Compania = compania;
        }
        public void CrearDireccion(string calle, string colonia, string municipioCiudad, string estado, string pais, string codigoPostal)
        {
            Direccion = "Calle: " + calle + " Colonia: " + colonia + " Mpio/Ciud: " + municipioCiudad + " Estado: " + estado + " Pais: " + pais + " CodPostal: " + codigoPostal;
        }
    }
}
