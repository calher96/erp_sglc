namespace CEN.Entidad
{
    public class ent_Empresa
    {
        public int Id { get; set; }
        public String RazonSocial { get; set; }
        public String Ruc { get; set; }
        public String Logo { get; set; }
        public List<ent_Sucursal> Lista_Sucursal { get; set; }

        public ent_Empresa()
        {
            Id = 0;
            RazonSocial = String.Empty;
            Ruc = String.Empty;
            Logo = String.Empty;
            Lista_Sucursal = new List<ent_Sucursal>();
        }
    }
}