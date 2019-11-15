
namespace Serene1.CLIN.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("DBO.PlantillaCorreo")]
    [BasedOnRow(typeof(Entities.PlantillaCorreoRow), CheckNames = true)]
    public class PlantillaCorreoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String CodigoPlantilla { get; set; }
        public String NombrePlantilla { get; set; }
        public String PerfilCorreo { get; set; }
        public String Modulo { get; set; }
        public String Tabla { get; set; }
        public String Campo { get; set; }

        /*
        public String CreadoPor { get; set; }

        public String ModificadoPor { get; set; }

        public String FechaCreacion { get; set; }

        public String FechaModificacion { get; set; }*/
    }
}