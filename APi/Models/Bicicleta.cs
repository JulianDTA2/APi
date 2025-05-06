using System.Text.Json.Serialization;

namespace APi.Models
{
    public class Bicicleta
    {
        [JsonRequired]
        
        public int Id { get; set; }
        public string Marca { get; set;}
        public string Material { get; set; }
        public double Costo { get; set; }
        public bool EsNueva { get; set; }

    }
}
