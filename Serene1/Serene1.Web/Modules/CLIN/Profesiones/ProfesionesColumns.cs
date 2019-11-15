
namespace Serene1.CLIN.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("CLIN.Profesiones")]
    [BasedOnRow(typeof(Entities.ProfesionesRow), CheckNames = true)]
    public class ProfesionesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String CodigoProfesion { get; set; }
        public String CodigoAlterno { get; set; }
        public String NombreProfesion { get; set; }
        public Decimal Puntaje { get; set; }
        public Int32 Activo { get; set; }
        public Boolean Visible { get; set; }
        public Boolean Permitido { get; set; }
    }
}