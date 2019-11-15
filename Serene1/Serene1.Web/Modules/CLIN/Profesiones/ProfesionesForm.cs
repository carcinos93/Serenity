
namespace Serene1.CLIN.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("CLIN.Profesiones")]
    [BasedOnRow(typeof(Entities.ProfesionesRow), CheckNames = true)]
    public class ProfesionesForm
    {
        [HideOnUpdate]
        public String CodigoProfesion { get; set; }
        public String CodigoAlterno { get; set; }
        public String NombreProfesion { get; set; }
        public Decimal Puntaje { get; set; }
        public Int32 Activo { get; set; }
        public Boolean Visible { get; set; }
        public Boolean Permitido { get; set; }
    }
}