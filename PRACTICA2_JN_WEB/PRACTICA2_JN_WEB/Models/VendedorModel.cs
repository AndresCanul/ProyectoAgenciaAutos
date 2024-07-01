using PRACTICA2_JN_WEB.Entities;

namespace PRACTICA2_JN_WEB.Models
{
    public class VendedorModel(HttpClient httpClient, IConfiguration iConfiguration) : IVendedorModel
    {
        public Respuesta RegistrarVendedor(Vendedor entidad)
        {
            using (httpClient)
            {
                string url = iConfiguration.GetSection("Llaves:UrlApi").Value + "Vendedor/RegistrarVendedor";
                JsonContent body = JsonContent.Create(entidad);
                var respuesta = httpClient.PostAsync(url, body).Result;

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<Respuesta>().Result!;
                else
                    return new Respuesta();
            }
        }
    }
}
