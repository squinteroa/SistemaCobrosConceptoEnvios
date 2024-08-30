using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace SistemaCobrosConceptoEnvios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaEnvios sistema = new SistemaEnvios();

            // Creación de tres objetos Remitente con diferentes datos
            Remitente remitente1 = new Remitente("John Doe", "Ventas", "123456789");
            Remitente remitente2 = new Remitente("Maria Perez", "Compras", "987654321");
            Remitente remitente3 = new Remitente("Carlos Ramirez", "Logística", "456789123");

            // Creación de tres objetos Destinatario con diferentes datos y direcciones
            Destinatario destinatario1 = new Destinatario("Acme Corp", "Jane Smith", "Gekon System");
            destinatario1.CrearDireccion("Av. Principal 123", "Centro", "Ciudad XYZ", "Estado ABC", "País DEF", "12345");

            Destinatario destinatario2 = new Destinatario("Globex Corp", "Alice Johnson", "Core Services");
            destinatario2.CrearDireccion("Calle Secundaria 456", "Norte", "Ciudad MNO", "Estado DEF", "País GHI", "67890");

            Destinatario destinatario3 = new Destinatario("Initech LLC", "Bob Brown", "Systems Integration");
            destinatario3.CrearDireccion("Blvd. Industrial 789", "Este", "Ciudad PQR", "Estado GHI", "País JKL", "11223");

            Console.WriteLine("Direccion: "+ destinatario1.Direccion);

            Servicio servicio1 = new Caja();
            Servicio servicio2 = new Sobre();
            Servicio servicio3 = new Paquete();

            // Crear una guía
            Guia guia1 = new Guia(1001, 2.5f, 1500.75m, false, destinatario1, remitente1, servicio1);
            Guia guia2 = new Guia(1002, 5.0f, 3000.00m, true, destinatario2, remitente2, servicio2);
            Guia guia3 = new Guia(1003, 1.2f, 500.00m, false, destinatario3, remitente3, servicio3);

            Console.WriteLine("REGISTRAR GUIAS");
            sistema.RegistrarGuia(guia1);
            sistema.RegistrarGuia(guia2);
            sistema.RegistrarGuia(guia3);

            Console.WriteLine("CONSULTAR ESTADO GUIAS");
            sistema.ConsultarGuiasPorEstado("DESPACHO");

            Console.WriteLine("ENTREGA FINALIZADA");
            guia1.FinalizarEntrega();
            guia2.FinalizarEntrega();
            guia3.FinalizarEntrega();

            Console.WriteLine("CONSULTAR ESTADO GUIAS");
            sistema.ConsultarGuiasPorEstado("FINALIZADA");


            Console.WriteLine("CONSULTAR GUIAS POR DESTINATARIO");
            // Consultar guías por destinatario
            sistema.ConsultarGuiasPorDestinatario(destinatario1.Nombre);
            sistema.ConsultarGuiasPorDestinatario(destinatario2.Nombre);
            sistema.ConsultarGuiasPorDestinatario(destinatario3.Nombre);

            Console.ReadLine();
        }
    }
}
