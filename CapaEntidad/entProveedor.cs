using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        public int ProveedorID { get; set; }
        public int CiudadID { get; set; }
        public string Nombre { get; set; }
        public int RubroID { get; set; }
        public int Ruc { get; set; }
        public Boolean estProveedor { get; set; }

    }
}
