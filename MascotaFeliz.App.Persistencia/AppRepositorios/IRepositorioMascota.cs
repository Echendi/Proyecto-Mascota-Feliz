using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota//  la interfaz define la firma de los métodos
    {
        //IEnumerable<Dueno> GetAllDuenos();
        Mascota AddMascota(Mascota mascota);
        Mascota GetMascota(int idMascota);
        IEnumerable<Mascota> GetAllMascotas();
    }
}