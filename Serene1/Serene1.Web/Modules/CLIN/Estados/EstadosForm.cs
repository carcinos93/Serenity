
namespace Serene1.CLIN.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("CLIN.Estados")]
    [BasedOnRow(typeof(Entities.EstadosRow), CheckNames = true)]
    public class EstadosForm
    {
        public String Nombre { get; set; }
        public String CodigoModulo { get; set; }
        public String Tabla { get; set; }
        public Int64 Secuencia { get; set; }
        public String ExcentoInteresDiario { get; set; }
        public String ExcentoInteresMora { get; set; }
        public String ExcentoSeguro1 { get; set; }
        public String ExcentoSeguro2 { get; set; }
        public String ExcentoSeguro3 { get; set; }
        public String Esmora { get; set; }
        public String Esinicio { get; set; }
        public String Esfin { get; set; }
        public String Estransaccional { get; set; }
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