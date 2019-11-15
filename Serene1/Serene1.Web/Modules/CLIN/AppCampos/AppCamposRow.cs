
namespace Serene1.CLIN.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CLINVP"), Module("CLIN"), TableName("[dbo].[APP_CAMPOS]")]
    [DisplayName("App Campos"), InstanceName("App Campos")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LeftJoin("cd", "APP_FORMULARIO", "cd.ID = T0.ID_FORMULARIO")]
    public sealed class AppCamposRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Id Formulario"), Column("ID_FORMULARIO"), LookupEditor("CLIN.APP_FORMULARIO")]
        public Guid? IdFormulario
        {
            get { return Fields.IdFormulario[this]; }
            set { Fields.IdFormulario[this] = value; }
        }

        [DisplayName("Formulario"), Expression("cd.FORMULARIO"), QuickSearch, ReadOnly(true) ]
        public String NombreFormulario
        {
            get { return Fields.NombreFormulario[this]; }
            set { Fields.NombreFormulario[this] = value; }
        }



        [DisplayName("Campo"), Column("CAMPO"), Size(100), QuickSearch]
        public String Campo
        {
            get { return Fields.Campo[this]; }
            set { Fields.Campo[this] = value; }
        }

        [DisplayName("Label"), Column("LABEL"), Size(50)]
        public String Label
        {
            get { return Fields.Label[this]; }
            set { Fields.Label[this] = value; }
        }

        [DisplayName("Mascara"), Column("MASCARA"), Size(100)]
        public String Mascara
        {
            get { return Fields.Mascara[this]; }
            set { Fields.Mascara[this] = value; }
        }

        [DisplayName("Longitud"), Column("LONGITUD")]
        public Int32? Longitud
        {
            get { return Fields.Longitud[this]; }
            set { Fields.Longitud[this] = value; }
        }

        [DisplayName("Tipo"), Column("TIPO")]
        public String Tipo
        {
            get { return Fields.Tipo[this]; }
            set { Fields.Tipo[this] = value; }

        }
        [DisplayName("Catalogo"), Column("CATALOGO"), Size(50)]
        public String Catalogo
        {
            get { return Fields.Catalogo[this]; }
            set { Fields.Catalogo[this] = value; }
        }

        [DisplayName("Activo"), Column("ACTIVO")]
        public Boolean? Activo
        {
            get { return Fields.Activo[this]; }
            set { Fields.Activo[this] = value; }
        }

        [DisplayName("Orden"), Column("ORDEN")]
        public Int32? Orden
        {
            get { return Fields.Orden[this]; }
            set { Fields.Orden[this] = value; }
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
            get { return Fields.Campo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AppCamposRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public GuidField IdFormulario;
            public StringField NombreFormulario;
            public StringField Campo;
            public StringField Label;
            public StringField Mascara;
            public Int32Field Longitud;
            public StringField Tipo;
            public StringField Catalogo;
            public BooleanField Activo;
            public Int32Field Orden;
            public StringField CreadoPor;
            public DateTimeField FechaCreacion;
            public StringField ModificadoPor;
            public DateTimeField FechaModificacion;
        }
    }
}
