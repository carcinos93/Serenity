
namespace Serene1.CLIN.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("DBO.Modulo")]
    [BasedOnRow(typeof(Entities.ModuloRow), CheckNames = true)]
    public class ModuloColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String CodigoModulo { get; set; }
        public String NombreModulo { get; set; }
        public String Protocolo { get; set; }
        public String SeparadorPuerto { get; set; }
        public String Puerto { get; set; }
        public String Servidor { get; set; }
    }
}