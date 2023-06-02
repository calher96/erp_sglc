using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
	public class ent_Cliente
	{
		public int Clie_Id { get; set; }
		public int Clie_TipoDocumento { get; set; }
		public String? Clie_TipoDocumentoDescripcion { get; set; }
		public String? Clie_Documento { get; set; }
		public Int16 Clie_TipoPersona { get; set; }
		public String? Clie_TipoPersonaDescripcion { get; set; }
		public String? Clie_RazonSocial { get; set; }
		public String? Clie_Nombres { get; set; }
		public String? Clie_ApellidoPaterno { get; set; }
		public String? Clie_ApellidoMaterno { get; set; }
		public int Clie_Sexo { get; set; }
		public String? Clie_SexoDescripcion { get; set; }
		public DateOnly Clie_FechaNacimiento { get; set; }
		public String? Clie_Codigo { get; set; }
		public Int16 Clie_Comisionista {get;set;}
		public String? Clie_Abreviatura { get; set; }
		public String? Clie_DomicilioFiscal { get; set; }
		public Int16 Clie_Estado { get; set; }
		public int empr_Id { get; set; }
    }
}
