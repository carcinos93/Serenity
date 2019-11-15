
namespace Serene1.CLIN.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CLINVP"), Module("CLIN"), TableName("[dbo].[tablas]")]
    [DisplayName("Tablas"), InstanceName("Tablas")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("CLIN.Tablas")]
    public sealed class TablasRow : Row, IIdRow, INameRow
    {
        [DisplayName("Esquema"), Column("ESQUEMA"), Size(50), QuickSearch, LookupInclude]
        public String Esquema
        {
            get { return Fields.Esquema[this]; }
            set { Fields.Esquema[this] = value; }
        }

        [DisplayName("Tabla"), Column("TABLA"), Size(100), PrimaryKey]
        public String Tabla
        {
            get { return Fields.Tabla[this]; }
            set { Fields.Tabla[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Tabla; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Tabla; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TablasRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField Esquema;
            public StringField Tabla;
        }
    }
}
