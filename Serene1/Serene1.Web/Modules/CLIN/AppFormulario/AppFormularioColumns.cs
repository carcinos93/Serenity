
namespace Serene1.CLIN.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("CLIN.AppFormulario")]
    [BasedOnRow(typeof(Entities.AppFormularioRow), CheckNames = true)]
    public class AppFormularioColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Guid Id { get; set; }
        [EditLink]
        public String Formulario { get; set; }
        public String Titulo { get; set; }
        public String CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public String ModificadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}