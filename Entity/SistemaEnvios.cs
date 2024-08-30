using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SistemaEnvios
    {
        private List<Guia> guias;

        public SistemaEnvios()
        {
            guias = new List<Guia>();
        }

        public void RegistrarGuia(Guia guia)
        {
            guias.Add(guia);
            Console.WriteLine($"Guía {guia.NumeroGuia} registrada.");
        }

        public void ConsultarGuiasPorEstado(string estado)
        {
            foreach (var guia in guias)
            {
                if (guia.EstadoGuia == estado)
                {
                    Console.WriteLine($"Guía {guia.NumeroGuia} - Estado: {guia.EstadoGuia}");
                }
            }
        }

        public void ConsultarGuiasPorDestinatario(string destinatario)
        {
            foreach (var guia in guias)
            {
                if (guia.Destinatario.Nombre.Contains(destinatario))
                {
                    Console.WriteLine($"Guía {guia.NumeroGuia} - Destinatario: {guia.Destinatario.Nombre}");
                }
            }
        }
    }
}
