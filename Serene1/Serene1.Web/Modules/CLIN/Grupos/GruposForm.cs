
namespace Serene1.CLIN.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("CLIN.Grupos")]
    [BasedOnRow(typeof(Entities.GruposRow), CheckNames = true)]
    public class GruposForm
    {
        public String NombreGrupo { get; set; }
        public String Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public String CreadoPor { get; set; }
        public String ModificadoPor { get; set; }
    }
}