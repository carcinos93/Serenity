
namespace Serene1.CLIN.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("CLIN.AppCampos")]
    [BasedOnRow(typeof(Entities.AppCamposRow), CheckNames = true)]
    public class AppCamposForm
    {

        public Guid IdFormulario { get; set; }
        public String Campo { get; set; }
        public String Label { get; set; }
        public String Mascara { get; set; }
        public Int32 Longitud { get; set; }
        public String Tipo { get; set; }
        public String Catalogo { get; set; }
        public Boolean Activo { get; set; }
    }
}