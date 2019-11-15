
namespace Serene1.CLIN.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CLINVP"), Module("CLIN"), TableName("[dbo].[GRUPOS]")]
    [DisplayName("Grupos"), InstanceName("Grupos")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class GruposRow : Row, IIdRow, INameRow
    {
        [DisplayName("Codigo Grupo"), Column("CODIGO_GRUPO"), Size(20), PrimaryKey, QuickSearch]
        public String CodigoGrupo
        {
            get { return Fields.CodigoGrupo[this]; }
            set { Fields.CodigoGrupo[this] = value; }
        }

        [DisplayName("Nombre Grupo"), Column("NOMBRE_GRUPO"), Size(100)]
        public String NombreGrupo
        {
            get { return Fields.NombreGrupo[this]; }
            set { Fields.NombreGrupo[this] = value; }
        }

        [DisplayName("Activo"), Column("ACTIVO"), Size(1), NotNull, ForeignKey("[AS].[DECISION]", "CODIGO_DECISION"), LeftJoin("jActivo"), TextualField("ActivoNombreDecision")]
        public String Activo
        {
            get { return Fields.Activo[this]; }
            set { Fields.Activo[this] = value; }
        }

        [DisplayName("Fecha Creacion"), Column("FECHA_CREACION")]
        public DateTime? FechaCreacion
        {
            get { return Fields.FechaCreacion[this]; }
            set { Fields.FechaCreacion[this] = value; }
        }

        [DisplayName("Fecha Modificacion"), Column("FECHA_MODIFICACION")]
        public DateTime? FechaModificacion
        {
            get { return Fields.FechaModificacion[this]; }
            set { Fields.FechaModificacion[this] = value; }
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

        [DisplayName("Activo Nombre Decision"), Expression("jActivo.[NOMBRE_DECISION]")]
        public String ActivoNombreDecision
        {
            get { return Fields.ActivoNombreDecision[this]; }
            set { Fields.ActivoNombreDecision[this] = value; }
        }

        [DisplayName("Activo Fecha Creacion"), Expression("jActivo.[FECHA_CREACION]")]
        public DateTime? ActivoFechaCreacion
        {
            get { return Fields.ActivoFechaCreacion[this]; }
            set { Fields.ActivoFechaCreacion[this] = value; }
        }

        [DisplayName("Activo Fecha Modificacion"), Expression("jActivo.[FECHA_MODIFICACION]")]
        public DateTime? ActivoFechaModificacion
        {
            get { return Fields.ActivoFechaModificacion[this]; }
            set { Fields.ActivoFechaModificacion[this] = value; }
        }

        [DisplayName("Activo Creado Por"), Expression("jActivo.[CREADO_POR]")]
        public String ActivoCreadoPor
        {
            get { return Fields.ActivoCreadoPor[this]; }
            set { Fields.ActivoCreadoPor[this] = value; }
        }

        [DisplayName("Activo Modificado Por"), Expression("jActivo.[MODIFICADO_POR]")]
        public String ActivoModificadoPor
        {
            get { return Fields.ActivoModificadoPor[this]; }
            set { Fields.ActivoModificadoPor[this] = value; }
        }

        [DisplayName("Activo Ip Cliente"), Expression("jActivo.[IP_CLIENTE]")]
        public String ActivoIpCliente
        {
            get { return Fields.ActivoIpCliente[this]; }
            set { Fields.ActivoIpCliente[this] = value; }
        }

        [DisplayName("Activo Aplicacion Origen"), Expression("jActivo.[APLICACION_ORIGEN]")]
        public String ActivoAplicacionOrigen
        {
            get { return Fields.ActivoAplicacionOrigen[this]; }
            set { Fields.ActivoAplicacionOrigen[this] = value; }
        }

        [DisplayName("Activo Host Cliente"), Expression("jActivo.[HOST_CLIENTE]")]
        public String ActivoHostCliente
        {
            get { return Fields.ActivoHostCliente[this]; }
            set { Fields.ActivoHostCliente[this] = value; }
        }

        [DisplayName("Activo"), Expression("jActivo.[ACTIVO]")]
        public Int32? Activo1
        {
            get { return Fields.Activo1[this]; }
            set { Fields.Activo1[this] = value; }
        }

        [DisplayName("Activo Visible"), Expression("jActivo.[VISIBLE]")]
        public Boolean? ActivoVisible
        {
            get { return Fields.ActivoVisible[this]; }
            set { Fields.ActivoVisible[this] = value; }
        }

        [DisplayName("Activo Permitido"), Expression("jActivo.[PERMITIDO]")]
        public Boolean? ActivoPermitido
        {
            get { return Fields.ActivoPermitido[this]; }
            set { Fields.ActivoPermitido[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CodigoGrupo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CodigoGrupo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public GruposRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField CodigoGrupo;
            public StringField NombreGrupo;
            public StringField Activo;
            public DateTimeField FechaCreacion;
            public DateTimeField FechaModificacion;
            public StringField CreadoPor;
            public StringField ModificadoPor;

            public StringField ActivoNombreDecision;
            public DateTimeField ActivoFechaCreacion;
            public DateTimeField ActivoFechaModificacion;
            public StringField ActivoCreadoPor;
            public StringField ActivoModificadoPor;
            public StringField ActivoIpCliente;
            public StringField ActivoAplicacionOrigen;
            public StringField ActivoHostCliente;
            public Int32Field Activo1;
            public BooleanField ActivoVisible;
            public BooleanField ActivoPermitido;
        }
    }
}
