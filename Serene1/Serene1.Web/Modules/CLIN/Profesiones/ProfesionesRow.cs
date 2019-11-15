
namespace Serene1.CLIN.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CLINVP"), Module("CLIN"), TableName("[AS].[PROFESIONES]")]
    [DisplayName("Profesiones"), InstanceName("Profesiones")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ProfesionesRow : Row, IIdRow, INameRow
    {
        [DisplayName("Codigo Profesion"), Column("CODIGO_PROFESION"), Size(25), PrimaryKey, QuickSearch]
        public String CodigoProfesion
        {
            get { return Fields.CodigoProfesion[this]; }
            set { Fields.CodigoProfesion[this] = value; }
        }

        [DisplayName("Codigo Alterno"), Column("CODIGO_ALTERNO"), Size(50)]
        public String CodigoAlterno
        {
            get { return Fields.CodigoAlterno[this]; }
            set { Fields.CodigoAlterno[this] = value; }
        }

        [DisplayName("Nombre Profesion"), Column("NOMBRE_PROFESION"), Size(250), NotNull, QuickSearch]
        public String NombreProfesion
        {
            get { return Fields.NombreProfesion[this]; }
            set { Fields.NombreProfesion[this] = value; }
        }

        [DisplayName("Puntaje"), Column("PUNTAJE"), Size(18), Scale(6)]
        public Decimal? Puntaje
        {
            get { return Fields.Puntaje[this]; }
            set { Fields.Puntaje[this] = value; }
        }

        [DisplayName("Fecha Creacion"), Column("FECHA_CREACION"), Updatable(false)]
        public DateTime? FechaCreacion
        {
            get { return Fields.FechaCreacion[this]; }
            set { Fields.FechaCreacion[this] = value; }
        }

        [DisplayName("Fecha Modificacion"), Column("FECHA_MODIFICACION"), Insertable(false)]
        public DateTime? FechaModificacion
        {
            get { return Fields.FechaModificacion[this]; }
            set { Fields.FechaModificacion[this] = value; }
        }

        [DisplayName("Creado Por"), Column("CREADO_POR"), Size(50), Updatable(false)]
        public String CreadoPor
        {
            get { return Fields.CreadoPor[this]; }
            set { Fields.CreadoPor[this] = value; }
        }

        [DisplayName("Modificado Por"), Column("MODIFICADO_POR"), Size(50), Insertable(false)]
        public String ModificadoPor
        {
            get { return Fields.ModificadoPor[this]; }
            set { Fields.ModificadoPor[this] = value; }
        }

        [DisplayName("Activo"), Column("ACTIVO")]
        public Int32? Activo
        {
            get { return Fields.Activo[this]; }
            set { Fields.Activo[this] = value; }
        }

        [DisplayName("Visible"), Column("VISIBLE")]
        public Boolean? Visible
        {
            get { return Fields.Visible[this]; }
            set { Fields.Visible[this] = value; }
        }

        [DisplayName("Permitido"), Column("PERMITIDO")]
        public Boolean? Permitido
        {
            get { return Fields.Permitido[this]; }
            set { Fields.Permitido[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CodigoProfesion; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CodigoProfesion; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProfesionesRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField CodigoProfesion;
            public StringField CodigoAlterno;
            public StringField NombreProfesion;
            public DecimalField Puntaje;
            public DateTimeField FechaCreacion;
            public DateTimeField FechaModificacion;
            public StringField CreadoPor;
            public StringField ModificadoPor;
            public Int32Field Activo;
            public BooleanField Visible;
            public BooleanField Permitido;
        }
    }
}
