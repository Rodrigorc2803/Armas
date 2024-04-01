using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma
{
    internal class Espada : Program
    {
        public float DañoDelArma;
        public float VelocidadDeAtaque;
        public float Peso;
        public float Precio;



        public virtual float DañoArma(float DañoDelArma)
        {
            this.DañoDelArma = DañoDelArma;
            Random daño = new Random();
            int Daño = daño.Next(150, 215);
            DañoDelArma = Daño;
            return DañoDelArma;
        }

        public virtual float VelocidadAtaque(float VelocidadDeAtaque)
        {
            this.VelocidadDeAtaque = VelocidadDeAtaque;
            Random velocidad = new Random();
            float Velocidad = velocidad.Next(40, 47);
            VelocidadDeAtaque = Velocidad;
            return VelocidadDeAtaque;
        }

        public virtual float PesoArma(float Peso)
        {
            this.Peso = Peso;
            Random peso = new Random();
            float Pesoarma = peso.Next(20, 35);
            Peso = Pesoarma;
            return Peso;
        }
        public virtual float Costo(float Precio)
        {
            this.Precio = Precio;
            Random precio = new Random();
            float I = precio.Next(340, 480);
            Precio = I;
            return Precio;
        }
    }
}

