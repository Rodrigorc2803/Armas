using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma
{
    internal class Program
    {
        public static float Dinero;
        static void Main(string[] args)
        {
                Comienzo();
                Continuar();
        }

        public static void Continuar()
        {
            Espada espada = new Espada();
            
            Arco arco = new Arco();
            Machete machete = new Machete();
            Pistola pistola = new Pistola();
            Escopeta escopeta = new Escopeta();
            int Opcion = int.Parse(Console.ReadLine());
            switch (Opcion)
            {
                case 1:
                    Dinero = Dinero;
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Espada");
                    Console.WriteLine("2. Arco");
                    Console.WriteLine("3. machete");
                    Console.WriteLine("4. Pistola");
                    Console.WriteLine("5. Escopeta");
                    Console.WriteLine($"Dinero :{Dinero}");

                    int caseArma = int.Parse(Console.ReadLine());
                    switch (caseArma)
                    {
                        case 1:

                            Console.WriteLine($"Daño Del Arma : {espada.DañoArma(espada.DañoDelArma)}");
                            Console.WriteLine($"Velocidad De Ataque:{espada.VelocidadAtaque(espada.VelocidadDeAtaque)}");
                            Console.WriteLine($"Peso Del Arma: {espada.PesoArma(espada.Peso)}");
                            Console.WriteLine($"Precio Del Arma: {espada.Costo(espada.Precio)}");
                            Console.WriteLine($"Dinero :{Dinero}");
                            Console.WriteLine($"1. Comprar");
                            Console.WriteLine($"2. Volver");
                            int come = int.Parse(Console.ReadLine());
                            switch (come)
                            {
                                case 1:
                                    Console.WriteLine("Comprando_escriba");
                                    Dinero = Dinero - espada.Precio;
                                    Continuar();
                                    break;
                                default:
                                    Console.WriteLine("Volviendo_escriba");
                                    Continuar();
                                    break;

                            }
                            break;

                        case 2:
                            Console.WriteLine($"Daño Del Arma :{arco.DañoArma(arco.DañoDelArma)}");
                            Console.WriteLine($"Velocidad De Ataque:{arco.VelocidadAtaque(arco.VelocidadDeAtaque)}");
                            Console.WriteLine($"Peso Del Arma:  {arco.PesoArma(arco.Peso)}");
                            Console.WriteLine($"Tipo de Proyectil {arco.Municion(arco.Proyectil)}");
                            Console.WriteLine($"Precio Del Arma: {arco.Costo(arco.Precio)}");
                            Console.WriteLine($"Dinero :{Dinero}");
                            Console.WriteLine($"1. Comprar");
                            Console.WriteLine($"2. Volver");
                            int comet = int.Parse(Console.ReadLine());
                            switch (comet)
                            {
                                case 1:
                                    Console.WriteLine("Comprando_escriba");
                                    Dinero = Dinero - arco.Precio;
                                    Continuar();
                                    break;
                                default:
                                    Console.WriteLine("Volviendo_escriba");
                                    Continuar();
                                    return;

                            }
                            break;
                        case 3:
                            Console.WriteLine($"Daño Del Arma :{machete.DañoArma(machete.DañoDelArma)}");
                            Console.WriteLine($"Velocidad De Ataque:{arco.VelocidadAtaque(machete.VelocidadDeAtaque)}");
                            Console.WriteLine($"Peso Del Arma:  {machete.PesoArma(machete.Peso)}");
                            Console.WriteLine($"Precio Del Arma: {machete.Costo(machete.Precio)}");
                            Console.WriteLine($"Dinero :{Dinero}");
                            Console.WriteLine($"1. Comprar");
                            Console.WriteLine($"2. Volver");
                            int cometi = int.Parse(Console.ReadLine());
                            switch (cometi)
                            {
                                case 1:
                                    Console.WriteLine("Comprando_escriba");
                                    Dinero = Dinero - machete.Precio;
                                    Continuar();
                                    break;
                                default:
                                    Console.WriteLine("Volviendo_escriba");
                                    Continuar();
                                    return;

                            }

                            break;
                        case 4:
                            Console.WriteLine($"Daño Del Arma : {pistola.DañoArma(pistola.DañoDelArma)}");
                            Console.WriteLine($"Velocidad De Ataque:{pistola.VelocidadAtaque(pistola.VelocidadDeAtaque)}");
                            Console.WriteLine($"Peso Del Arma:{pistola.PesoArma(machete.Peso)}");
                            Console.WriteLine($"Tipo de Proyectil {pistola.Municion(pistola.Proyectil)}");
                            Console.WriteLine($"Precio Del Arma:{pistola.Costo(machete.Precio)}");
                            Console.WriteLine($"Dinero :{Dinero}");
                            Console.WriteLine($"1. Comprar");
                            Console.WriteLine($"2. Volver");
                            int cometid = int.Parse(Console.ReadLine());
                            switch (cometid)
                            {
                                case 1:
                                    Console.WriteLine("Comprando_escriba");
                                    Dinero = Dinero - pistola.Precio;
                                    Continuar();
                                    break;
                                default:
                                    Console.WriteLine("Volviendo_escriba");
                                    Continuar(); 
                                    return;

                            }
                            break;
                        case 5:
                            Console.WriteLine($"Daño Del Arma : {escopeta.DañoArma(escopeta.DañoDelArma)}");
                            Console.WriteLine($"Velocidad De Ataque:{escopeta.VelocidadAtaque(escopeta.VelocidadDeAtaque)}");
                            Console.WriteLine($"Peso Del Arma: {escopeta.PesoArma(escopeta.Peso)}");
                            Console.WriteLine($"Tipo de Proyectil {escopeta.Municion(escopeta.Proyectil)}");
                            Console.WriteLine($"Preciio Del Arma: {escopeta.Precio}");
                            Console.WriteLine($"Precio Del Arma:{escopeta.Costo(machete.Precio)}");
                            Console.WriteLine($"1. Comprar");
                            Console.WriteLine($"2. Volver");
                            int cometido = int.Parse(Console.ReadLine());
                            switch (cometido)
                            {
                                case 1:
                                    Console.WriteLine("Comprando_escriba");
                                    Dinero = Dinero - escopeta.Precio;
                                    Continuar();
                                    break;
                                default:
                                    Console.WriteLine("Volviendo_escriba");
                                    Continuar();
                                    return;

                            }
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            return;

                    }

                    break;

                case 2:
                    Flecha flecha = new Flecha();
                    Bala bala = new Bala();
                    PerdigonDeEscopeta Perescopeta = new PerdigonDeEscopeta();

                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Flecha");
                    Console.WriteLine("2. Bala");
                    Console.WriteLine("3. Perdigon De Escopeta");

                    int casePerdigon = int.Parse(Console.ReadLine());

                    switch (casePerdigon)
                    {
                        case 1:
                            Console.WriteLine($"Daño al Impacto:{flecha.DañoImpacto(flecha.DañoAlImpacto)}");
                            Console.WriteLine($"Velocidad:{flecha.velocidad(flecha.Velocidad)}");
                            Console.WriteLine($"Distancia Efectiva:{flecha.DistanciaEfectiva(flecha.Distancia)}");
                            Console.WriteLine($"Precio:{flecha.Costo(flecha.Precio)}");
                            Console.WriteLine($"1. Comprar");
                            Console.WriteLine($"2. Volver");

                            int cometido = int.Parse(Console.ReadLine());
                            switch(cometido)
                            {
                                case 1:
                                    Console.WriteLine("Comprando_escriba");
                                    Dinero = Dinero - flecha.Precio;
                                    Continuar();
                                    break;
                                default:
                                    Console.WriteLine("Volviendo_escriba");
                                    Continuar();
                                    return;
                            }

                            
                         break;
                        case 2:
                            Console.WriteLine($"Daño al Impacto:{bala.DañoImpacto(bala.DañoAlImpacto)}");
                            Console.WriteLine($"Velocidad:{bala.velocidad(bala.Velocidad)}");
                            Console.WriteLine($"Distancia Efectiva:{bala.DistanciaEfectiva(bala.Distancia)}");
                            Console.WriteLine($"Precio:{bala.Costo(bala.Precio)}");
                            Console.WriteLine($"1. Comprar");
                            Console.WriteLine($"2. Volver");

                            int cOmetido = int.Parse(Console.ReadLine());
                            switch (cOmetido)
                            {
                                case 1:
                                    Console.WriteLine("Comprando_escriba");
                                    Dinero = Dinero - bala.Precio;
                                    Continuar();
                                    break;
                                default:
                                    Console.WriteLine("Volviendo_escriba");
                                    Continuar();
                                    return;
                            }

                            break;
                        case 3:
                            Console.WriteLine($"Daño al Impacto:{Perescopeta.DañoImpacto(Perescopeta.DañoAlImpacto)}");
                            Console.WriteLine($"Velocidad:{Perescopeta.velocidad(Perescopeta.Velocidad)}");
                            Console.WriteLine($"Distancia Efectiva:{Perescopeta.DistanciaEfectiva(Perescopeta.Distancia)}");
                            Console.WriteLine($"Precio:{Perescopeta.Costo(Perescopeta.Precio)}");
                            Console.WriteLine($"1. Comprar");
                            Console.WriteLine($"2. Volver");

                            int Cometido = int.Parse(Console.ReadLine());
                            switch (Cometido)
                            {
                                case 1:
                                    Console.WriteLine("Comprando_escriba");
                                    Dinero = Dinero - Perescopeta.Precio;
                                    Continuar();
                                    break;
                                default:
                                    Console.WriteLine("Volviendo_escriba");
                                    Continuar();
                                    return;
                            }

                            break;
                        default:
                            Console.WriteLine("Volviendo_escriba");
                            Continuar();
                            return;
                    }
                    break;

                default:
                    Console.WriteLine("Volviendo_escriba");
                    Continuar();
                    return;




            }
        }
            public static void Comienzo()
            {
                Console.WriteLine("Cuanto Dinero Necesitas:");
                float Dinero = float.Parse(Console.ReadLine());
                if (Dinero <= 350)
                {
                    Dinero = Dinero * 2;
                }
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Armas");
                Console.WriteLine("2. Proyectiles");
                Console.WriteLine($"Dinero :{Dinero}");       
            }
        }
     }
    

