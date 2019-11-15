
namespace Serene1.CLIN.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("CLIN.Estados")]
    [BasedOnRow(typeof(Entities.EstadosRow), CheckNames = true)]
    public class EstadosColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String CodigoEstadoNombre { get; set; }
        public String Nombre { get; set; }
        public String CodigoModuloNombreModulo { get; set; }
        public String Tabla { get; set; }
        public Int64 Secuencia { get; set; }
        public String ExcentoInteresDiarioNombreDecision { get; set; }
        public String ExcentoInteresMoraNombreDecision { get; set; }
        public String ExcentoSeguro1NombreDecision { get; set; }
        public String ExcentoSeguro2NombreDecision { get; set; }
        public String ExcentoSeguro3NombreDecision { get; set; }
        public String EsmoraNombreDecision { get; set; }
        public String EsinicioNombreDecision { get; set; }
        public String EsfinNombreDecision { get; set; }
        public String EstransaccionalNombreDecision { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public String CreadoPor { get; set; }
        public String ModificadoPor { get; set; }
        public String IpCliente { get; set; }
        public String AplicacionOrigen { get; set; }
        public String HostCliente { get; set; }
        public Int32 Activo { get; set; }
        public Boolean Visible { get; set; }
        public Boolean Permitido { get; set; }
    }
}