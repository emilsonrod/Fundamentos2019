using ProyectoHerencia.ClaseAbstracta;
using ProyectoHerencia.CursosOfrecidos;
using ProyectoHerencia.FiguraGeometrica;
using ProyectoHerencia.Interfaces;
using ProyectoHerencia.ManejadorNumeros;
using ProyectoHerencia.Transporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cuadrado cuadrado1 = new Cuadrado(10,10);
            //Console.WriteLine(cuadrado1.AreaFigura());
            //Rectangulo rectangulo1 = new Rectangulo() { Altura = 20, Base = 10 };
            //Console.WriteLine(rectangulo1.AreaFigura());

            //CursoRapido cursoRapido = new CursoRapido()
            //{
            //    CantidadSubcursos = 0,
            //    DuracionDias = 10,
            //    FechaInicio = new DateTime().AddDays(30),
            //    NombreCurso = "IT"
            //};
            //CursoCertificacion certificado1 = new CursoCertificacion()
            //{
            //    NombreCurso = "C#",
            //    FechaInicio = new DateTime(60),
            //    DuracionDias = 25,
            //    Promotor = "Microsoft",
            //    CantidadSubcursos = 3,
            //    CodCertificacion = 483
            //};

            //cursoRapido.PublicitarCurso();
            //certificado1.PublicitarCurso();

            //Curso cursoGenerico = cursoRapido;
            //cursoGenerico = certificado1;

            //Curso curso2 = new CursoCertificacion() { CodCertificacion = 586 };
            //curso2 = new CursoRapido() { NombreCurso = "Redes" };
            //curso2 = new CursoCertificacion() { CodCertificacion = 369 };
            //CursoCertificacion objeto586 = curso2 as CursoCertificacion;
            //if (objeto586 != null)
            //    Console.WriteLine(objeto586.CodCertificacion);
            //curso2 = new CursoCertificacion() { CodCertificacion = 369 };
            //if (curso2 is CursoCertificacion)
            //{
            //    CursoCertificacion objeto586 = (CursoCertificacion)curso2;
            //}

            //List<Curso> listaCursos = new List<Curso>();
            //listaCursos.Add()

            //List<VehiculoAbstracto> listaTransporte = new List<VehiculoAbstracto>();
            //Aereo avion1 = new Aereo() { VelocidadCrucero = 1500 };
            //Fluvial bote1 = new Fluvial();
            //Terrestre terrestre1 = new Terrestre() { ValocidadLineal = 120 };
            //Terrestre terrestre2 = new Terrestre() { ValocidadLineal = 150 };
            //Terrestre terrestre3 = new Terrestre() { ValocidadLineal = 200 };
            //Vehiculo vehiculoTest = new Vehiculo() { Marce =  "Patito", CapacidadPasajeros = 10 };
            //VehiculoAbstracto vehiculoAbstractoTest = new VehiculoAbstracto();
            //listaTransporte.Add(avion1);
            //listaTransporte.Add(bote1);
            //listaTransporte.Add(terrestre1);
            //listaTransporte.Add(terrestre2);
            //listaTransporte.Add(terrestre3);
            //foreach (VehiculoAbstracto vehiculo in listaTransporte)
            //{
            //    if (vehiculo is Terrestre)
            //    {

            //        Console.WriteLine(((Terrestre)vehiculo).ValocidadLineal);
            //    }
            //    Terrestre carro = vehiculo as Terrestre;
            //    if(carro != null)
            //        Console.WriteLine(carro.ValocidadLineal);
            //    vehiculo.ImprimirVehiculo();
            //}
            IFiltro[] listaFiltros = {new FiltrosNumericos.FiltrarPares() , new FiltrosNumericos.FiltrarInpares() };
            ManejadorNumbers manejador = new ManejadorNumbers();
            Console.WriteLine("Ingrese la cantidad de numeros");
            manejador.LLenarLista(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("1 para filtrar pares - 2 para filtrar inpares");
            List<int> numeros = manejador.FiltrarNumeros(listaFiltros[Convert.ToInt32(Console.ReadLine()) - 1]);
            ImprimirLista(numeros);
        }

        public static void ImprimirLista(List<int> listaNumeros)
        {
            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
