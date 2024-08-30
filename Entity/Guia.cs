using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Guia
    {
        public int NumeroGuia { get; set; }
        public float Peso { get; set; }
        public decimal ValorDeclarado { get; set; }
        public bool EsInternacional { get; set; }
        public string EstadoGuia { get; set; }
        public Destinatario Destinatario { get; private set; }
        public Remitente Remitente { get; private set; }
        public Servicio TipoServicio { get; private set; }

        public Guia(int numeroGuia, float peso, decimal valorDeclarado, bool esInternacional, Destinatario destinatario, Remitente remitente, Servicio tipoServicio)
        {
            NumeroGuia = numeroGuia;
            Peso = peso;
            ValorDeclarado = valorDeclarado;
            EsInternacional = esInternacional;
            EstadoGuia = "DESPACHO";
            Destinatario = destinatario ?? throw new ArgumentNullException(nameof(destinatario));
            Remitente = remitente ?? throw new ArgumentNullException(nameof(remitente));
            TipoServicio = tipoServicio ?? throw new ArgumentNullException(nameof(tipoServicio));
        }

        public decimal CalcularCosto()
        {
            decimal costo = TipoServicio.CalcularTarifa(Peso);
            if (EsInternacional)
            {
                costo += costo * 0.25m;
            }
            return costo;
        }

        public void FinalizarEntrega()
        {
            EstadoGuia = "FINALIZADA";
            Console.WriteLine($"Guía {NumeroGuia} finalizada. Costo total: {CalcularCosto()}");
        }
    }
}
