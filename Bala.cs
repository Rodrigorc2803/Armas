using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma
{
    internal class Bala : Program
    {
        public float DañoAlImpacto;
        public float Velocidad;
        public string Distancia;
        public float Precio;

        public virtual float DañoImpacto(float DañoAlImpacto)
        {
            this.DañoAlImpacto = DañoAlImpacto;
            Random daño = new Random();
            int Daño = daño.Next(200, 650);
            DañoAlImpacto = Daño;
            return DañoAlImpacto;
        }
        public virtual float velocidad(float Velocidad)
        {
            this.Velocidad = Velocidad;
            float I = 600;
            Velocidad = I;
            return Velocidad;
        }

        public virtual string DistanciaEfectiva(string Distancia)
        {
            this.Distancia = Distancia;

            string larga = "larga Distancia";
            Distancia = larga;
            return Distancia;
        }
        public virtual float Costo(float Precio)
        {
            this.Precio = Precio;
            Random precio = new Random();
            float I = precio.Next(35, 30);
            Precio = I;
            return Precio;
        }



    }
}
