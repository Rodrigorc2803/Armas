using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma
{
    internal class Flecha : Program
    {
        public float DañoAlImpacto;
        public float Velocidad;
        public string Distancia;
        public float Precio;

        public virtual float DañoImpacto(float DañoAlImpacto)
        {
            this.DañoAlImpacto = DañoAlImpacto;
            Random daño = new Random();
            int Daño = daño.Next(150, 250);
            DañoAlImpacto = Daño;
            return DañoAlImpacto;
        }
        public virtual float velocidad(float Velocidad)
        {
            this.Velocidad = Velocidad;
            Random trayectoria = new Random();
            float I = trayectoria.Next(50, 430);
            Velocidad = I;
            return Velocidad;
        }

        public virtual string DistanciaEfectiva(string Distancia)
        {
            this.Distancia = Distancia;

            string media = "Media Distancia";
            Distancia = media;
            return Distancia;
        }
        public virtual float Costo(float Precio)
        {
            this.Precio = Precio;
            Random precio = new Random();
            float I = precio.Next(20, 26);
            Precio = I;
            return Precio;
        }
    }
}
