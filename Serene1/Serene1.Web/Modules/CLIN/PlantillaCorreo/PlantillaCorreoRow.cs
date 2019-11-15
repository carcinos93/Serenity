
namespace Serene1.CLIN.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CLINVP"), Module("CLIN"), TableName("[dbo].[PLANTILLA_CORREO]")]
    [DisplayName("Plantilla Correo"), InstanceName("Plantilla Correo")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PlantillaCorreoRow : Row, IIdRow, INameRow
    {
        [DisplayName("Codigo Plantilla"), Column("CODIGO_PLANTILLA"), Size(100), PrimaryKey, QuickSearch]
        public String CodigoPlantilla
        {
            get { return Fields.CodigoPlantilla[this]; }
            set { Fields.CodigoPlantilla[this] = value; }
        }

        [DisplayName("Nombre Plantilla"), Column("NOMBRE_PLANTILLA"), Size(100), NotNull]
        public String NombrePlantilla
        {
            get { return Fields.NombrePlantilla[this]; }
            set { Fields.NombrePlantilla[this] = value; }
        }

        [DisplayName("Perfil Correo"), Column("PERFIL_CORREO"), Size(10), NotNull]
        public String PerfilCorreo
        {
            get { return Fields.PerfilCorreo[this]; }
            set { Fields.PerfilCorreo[this] = value; }
        }

        [DisplayName("Modulo"), Column("MODULO"), Size(128)]
        public String Modulo
        {
            get { return Fields.Modulo[this]; }
            set { Fields.Modulo[this] = value; }
        }

        [DisplayName("Tabla"), Column("TABLA"), Size(128), NotNull]
        public String Tabla
        {
            get { return Fields.Tabla[this]; }
            set { Fields.Tabla[this] = value; }
        }

        [DisplayName("Campo"), Column("CAMPO"), Size(128)]
        public String Campo
        {
            get { return Fields.Campo[this]; }
            set { Fields.Campo[this] = value; }
        }

        [DisplayName("Cuerpo"), Column("CUERPO")]
        public String Cuerpo
        {
            get { return Fields.Cuerpo[this]; }
            set { Fields.Cuerpo[this] = value; }
        }

        [DisplayName("Creado Por"), Column("CREADO_POR"), Size(50)]
        public String CreadoPor
        {
            get { return Fields.CreadoPor[this]; }
            set { Fields.CreadoPor[this] = value; }
        }

        [DisplayName("Modificado Por"), Column("MODIFICADO_POR"), Size(50)]
        public String ModificadoPor
        {
            get { return Fields.ModificadoPor[this]; }
            set { Fields.ModificadoPor[this] = value; }
        }

        [DisplayName("Fecha Creacion"), Column("FECHA_CREACION"), Size(50)]
        public String FechaCreacion
        {
            get { return Fields.FechaCreacion[this]; }
            set { Fields.FechaCreacion[this] = value; }
        }

        [DisplayName("Fecha Modificacion"), Column("FECHA_MODIFICACION"), Size(50)]
        public String FechaModificacion
        {
            get { return Fields.FechaModificacion[this]; }
            set { Fields.FechaModificacion[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CodigoPlantilla; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CodigoPlantilla; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PlantillaCorreoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField CodigoPlantilla;
            public StringField NombrePlantilla;
            public StringField PerfilCorreo;
            public StringField Modulo;
            public StringField Tabla;
            public StringField Campo;
            public StringField Cuerpo;
            public StringField CreadoPor;
            public StringField ModificadoPor;
            public StringField FechaCreacion;
            public StringField FechaModificacion;
        }
    }
}
