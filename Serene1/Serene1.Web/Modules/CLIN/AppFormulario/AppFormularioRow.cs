
namespace Serene1.CLIN.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CLINVP"), Module("CLIN"), TableName("[dbo].[APP_FORMULARIO]")]
    [DisplayName("App Formulario"), InstanceName("App Formulario")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("CLIN.APP_FORMULARIO")]
    public sealed class AppFormularioRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), PrimaryKey]
        public Guid? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Formulario"), Column("FORMULARIO"), Size(50), QuickSearch]
        public String Formulario
        {
            get { return Fields.Formulario[this]; }
            set { Fields.Formulario[this] = value; }
        }

        [DisplayName("Titulo"), Column("TITULO"), Size(500)]
        public String Titulo
        {
            get { return Fields.Titulo[this]; }
            set { Fields.Titulo[this] = value; }
        }

        [DisplayName("Creado Por"), Column("CREADO_POR"), Size(50)]
        public String CreadoPor
        {
            get { return Fields.CreadoPor[this]; }
            set { Fields.CreadoPor[this] = value; }
        }

        [DisplayName("Fecha Creacion"), Column("FECHA_CREACION")]
        public DateTime? FechaCreacion
        {
            get { return Fields.FechaCreacion[this]; }
            set { Fields.FechaCreacion[this] = value; }
        }

        [DisplayName("Modificado Por"), Column("MODIFICADO_POR"), Size(50)]
        public String ModificadoPor
        {
            get { return Fields.ModificadoPor[this]; }
            set { Fields.ModificadoPor[this] = value; }
        }

        [DisplayName("Fecha Modificacion"), Column("FECHA_MODIFICACION")]
        public DateTime? FechaModificacion
        {
            get { return Fields.FechaModificacion[this]; }
            set { Fields.FechaModificacion[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Formulario; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AppFormularioRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public GuidField Id;
            public StringField Formulario;
            public StringField Titulo;
            public StringField CreadoPor;
            public DateTimeField FechaCreacion;
            public StringField ModificadoPor;
            public DateTimeField FechaModificacion;
        }
    }
}
