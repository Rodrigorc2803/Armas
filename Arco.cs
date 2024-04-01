using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma
{
    internal class Arco : Program
    {
        public float DañoDelArma;
        public float VelocidadDeAtaque;
        public float Peso;
        public string Proyectil;
        public float Precio;


        public virtual float DañoArma(float DañoDelArma)
        {
            this.DañoDelArma = DañoDelArma;
            Random daño = new Random();
            int Daño = daño.Next(25, 33);
            DañoDelArma = Daño;
            return DañoDelArma;
        }

        public virtual float VelocidadAtaque(float VelocidadDeAtaque)
        {
            this.VelocidadDeAtaque = VelocidadDeAtaque;
            Random velocidad = new Random();
            float Velocidad = velocidad.Next(10, 22);
            VelocidadDeAtaque = Velocidad;
            return VelocidadDeAtaque;
        }

        public virtual float PesoArma(float Peso)
        {
            this.Peso = Peso;
            Random peso = new Random();
            float Pesoarma = peso.Next(5, 9);
            Peso = Pesoarma;
            return Peso;
        }

        public virtual string Municion(string Proyectil)
        {
            this.Proyectil = Proyectil;

            string bala = "Flecha";
            Proyectil = bala;
            return Proyectil;
        }
        public virtual float Costo(float Precio)
        {
            this.Precio = Precio;
            Random precio = new Random();
            float I = precio.Next(70, 140);
            Precio = I;
            return Precio;
        }
    }
}
