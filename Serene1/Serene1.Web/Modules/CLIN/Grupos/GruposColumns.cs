
namespace Serene1.CLIN.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("CLIN.Grupos")]
    [BasedOnRow(typeof(Entities.GruposRow), CheckNames = true)]
    public class GruposColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String CodigoGrupo { get; set; }
        public String NombreGrupo { get; set; }
        public String ActivoNombreDecision { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public String CreadoPor { get; set; }
        public String ModificadoPor { get; set; }
    }
}