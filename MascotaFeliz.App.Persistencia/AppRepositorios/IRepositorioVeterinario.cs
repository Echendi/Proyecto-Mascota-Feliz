using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVeterinario//  la interfaz define la firma de los métodos
    {
        //IEnumerable<Dueno> GetAllDuenos();
        Veterinario AddVeterinario(Veterinario veterinario);
       
    }
}