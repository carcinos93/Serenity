
namespace Serene1.CLIN.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("DBO.Modulo")]
    [BasedOnRow(typeof(Entities.ModuloRow), CheckNames = true)]
    public class ModuloForm
    {
        public String NombreModulo { get; set; }
        public String Protocolo { get; set; }
        public String SeparadorPuerto { get; set; }
        public String Puerto { get; set; }
        public String Servidor { get; set; }
    }
}