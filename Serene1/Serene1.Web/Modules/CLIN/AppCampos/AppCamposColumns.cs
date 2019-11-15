
namespace Serene1.CLIN.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("CLIN.AppCampos")]
    [BasedOnRow(typeof(Entities.AppCamposRow), CheckNames = true)]
    public class AppCamposColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String NombreFormulario { get; set; }
        [EditLink]
        public String Campo { get; set; }
        public String Label { get; set; }
        public String Mascara { get; set; }
        public Int32 Longitud { get; set; }
        public String Tipo { get; set; }
        public String Catalogo { get; set; }
        public Boolean Activo { get; set; }
        public String CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public String ModificadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}