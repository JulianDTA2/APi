using APi.Models;

namespace APi.Repo
{
    public class BicicletasRepo
    {
        public IEnumerable<Bicicleta> ObtenerListadoBicicletas()
        {
            List<Bicicleta> bicicletas = new List<Bicicleta>();
            Bicicleta bicicleta1 = new Bicicleta
            {
                Id = 1,
                Marca = "Marca1",
                Costo = 1000,
                Material = "Aluminio",
                EsNueva = true
            };
            Bicicleta bicicleta2 = new Bicicleta
            {
                Id = 2,
                Marca = "Marca2",
                Costo = 1200,
                Material = "Aluminio",
                EsNueva = false
            };
            bicicletas.Add(bicicleta1);
            bicicletas.Add(bicicleta2);
            return bicicletas;
        }
        public Bicicleta ObtenerInformacionBicicletas(int Id)
        {
            var bicicletas = ObtenerListadoBicicletas();
            var bicicleta = bicicletas.First(Item => Item.Id == Id);
            return bicicleta;
        }
    }
}
