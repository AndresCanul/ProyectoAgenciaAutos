using Microsoft.Extensions.Configuration;
using PRACTICA2_JN_WEB.Entities;
using System.Net.Http;

namespace PRACTICA2_JN_WEB.Models
{
    public interface IVendedorModel
    {
        Respuesta RegistrarVendedor(Vendedor entidad);
    }
}
