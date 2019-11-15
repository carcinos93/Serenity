
namespace Serene1.CLIN.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CLINVP"), Module("CLIN"), TableName("[dbo].[MODULO]")]
    [DisplayName("Modulo"), InstanceName("Modulo")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("CLIN.Modulo")]
    public sealed class ModuloRow : Row, IIdRow, INameRow
    {
        [DisplayName("Codigo Modulo"), Column("CODIGO_MODULO"), Size(20), PrimaryKey, QuickSearch]
        public String CodigoModulo
        {
            get { return Fields.CodigoModulo[this]; }
            set { Fields.CodigoModulo[this] = value; }
        }

        [DisplayName("Nombre Modulo"), Column("NOMBRE_MODULO"), Size(100)]
        public String NombreModulo
        {
            get { return Fields.NombreModulo[this]; }
            set { Fields.NombreModulo[this] = value; }
        }

        [DisplayName("Protocolo"), Column("PROTOCOLO"), Size(10)]
        public String Protocolo
        {
            get { return Fields.Protocolo[this]; }
            set { Fields.Protocolo[this] = value; }
        }

        [DisplayName("Separador Puerto"), Column("SEPARADOR_PUERTO"), Size(1)]
        public String SeparadorPuerto
        {
            get { return Fields.SeparadorPuerto[this]; }
            set { Fields.SeparadorPuerto[this] = value; }
        }

        [DisplayName("Puerto"), Column("PUERTO"), Size(20)]
        public String Puerto
        {
            get { return Fields.Puerto[this]; }
            set { Fields.Puerto[this] = value; }
        }

        [DisplayName("Servidor"), Column("SERVIDOR"), Size(50)]
        public String Servidor
        {
            get { return Fields.Servidor[this]; }
            set { Fields.Servidor[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CodigoModulo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CodigoModulo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ModuloRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField CodigoModulo;
            public StringField NombreModulo;
            public StringField Protocolo;
            public StringField SeparadorPuerto;
            public StringField Puerto;
            public StringField Servidor;
        }
    }
}
