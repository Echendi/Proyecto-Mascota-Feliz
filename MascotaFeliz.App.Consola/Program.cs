using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {

        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext()); // la interfaz llamada _repodueno llama un constructor RepositorioDueno que recibe un appcontext (conector de la base de datos)
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("He aquí las mascotas registradas:"); 
            //AddDueno ();
            //BuscarDueno (1);
            //AddVeterinario ();
            //AddMascota ();
            //BuscarMascota (3);
            ListarMascotas ();
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Felipe",
                Apellidos = "Gutierrez",
                Direccion = "Calle 32 # 7- 15",
                Telefono = "3015896347",
                Correo = "flipeguz@hotmail.com"
            };
            _repoDueno.AddDueno(dueno);
            
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Camila",
                Apellidos = "Suarez",
                Direccion = "Calle 40 # 6-32",
                Telefono = "3017958624",
                //Correo = "juan@gmail.com"
                TargetaProfesional = "1158795423"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Lia",
                Color = "Gris",
                Especie = "Felino",
                Raza = "Korat"
                
            };
            _repoMascota.AddMascota(mascota);
        }
                
        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Color + " " + mascota.Especie + " " + mascota.Raza);
        }

                private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine (m.Nombre + " " + m.Color+" "+ m.Especie +" "+ m.Raza);
            }
        }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }


        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

    }
}