
namespace Serene1.CLIN.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("DBO.PlantillaCorreo")]
    [BasedOnRow(typeof(Entities.PlantillaCorreoRow), CheckNames = true)]
    public class PlantillaCorreoForm
    {
        public String NombrePlantilla { get; set; }
        public String PerfilCorreo { get; set; }
        [LookupEditor(typeof(Entities.ModuloRow))]
        public String Modulo { get; set; }

        [LookupEditor(typeof(Entities.TablasRow), CascadeFrom = "Modulo", CascadeField = "Esquema")]
        public String Tabla { get; set; }
        public String Campo { get; set; }
        [HtmlContentEditor]
        public String Cuerpo { get; set; }
    }
        

}