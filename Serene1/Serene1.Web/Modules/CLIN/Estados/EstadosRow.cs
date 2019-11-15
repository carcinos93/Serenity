
namespace Serene1.CLIN.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CLINVP"), Module("CLIN"), TableName("[AS].[ESTADOS]")]
    [DisplayName("Estados"), InstanceName("Estados")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class EstadosRow : Row, IIdRow, INameRow
    {
        [DisplayName("Codigo Estado"), Column("CODIGO_ESTADO"), Size(25), PrimaryKey, ForeignKey("[AS].[ESTADOS]", "CODIGO_ESTADO"), LeftJoin("jCodigoEstado"), QuickSearch, TextualField("CodigoEstadoNombre")]
        public String CodigoEstado
        {
            get { return Fields.CodigoEstado[this]; }
            set { Fields.CodigoEstado[this] = value; }
        }

        [DisplayName("Nombre"), Column("NOMBRE"), Size(50), NotNull]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Codigo Modulo"), Column("CODIGO_MODULO"), Size(20), NotNull, ForeignKey("[dbo].[MODULO]", "CODIGO_MODULO"), LeftJoin("jCodigoModulo"), TextualField("CodigoModuloNombreModulo")]
        public String CodigoModulo
        {
            get { return Fields.CodigoModulo[this]; }
            set { Fields.CodigoModulo[this] = value; }
        }

        [DisplayName("Tabla"), Column("TABLA"), Size(128)]
        public String Tabla
        {
            get { return Fields.Tabla[this]; }
            set { Fields.Tabla[this] = value; }
        }

        [DisplayName("Secuencia"), Column("SECUENCIA")]
        public Int64? Secuencia
        {
            get { return Fields.Secuencia[this]; }
            set { Fields.Secuencia[this] = value; }
        }

        [DisplayName("Excento Interes Diario"), Column("EXCENTO_INTERES_DIARIO"), Size(1), NotNull, ForeignKey("[AS].[DECISION]", "CODIGO_DECISION"), LeftJoin("jExcentoInteresDiario"), TextualField("ExcentoInteresDiarioNombreDecision")]
        public String ExcentoInteresDiario
        {
            get { return Fields.ExcentoInteresDiario[this]; }
            set { Fields.ExcentoInteresDiario[this] = value; }
        }

        [DisplayName("Excento Interes Mora"), Column("EXCENTO_INTERES_MORA"), Size(1), NotNull, ForeignKey("[AS].[DECISION]", "CODIGO_DECISION"), LeftJoin("jExcentoInteresMora"), TextualField("ExcentoInteresMoraNombreDecision")]
        public String ExcentoInteresMora
        {
            get { return Fields.ExcentoInteresMora[this]; }
            set { Fields.ExcentoInteresMora[this] = value; }
        }

        [DisplayName("Excento Seguro1"), Column("EXCENTO_SEGURO1"), Size(1), NotNull, ForeignKey("[AS].[DECISION]", "CODIGO_DECISION"), LeftJoin("jExcentoSeguro1"), TextualField("ExcentoSeguro1NombreDecision")]
        public String ExcentoSeguro1
        {
            get { return Fields.ExcentoSeguro1[this]; }
            set { Fields.ExcentoSeguro1[this] = value; }
        }

        [DisplayName("Excento Seguro2"), Column("EXCENTO_SEGURO2"), Size(1), NotNull, ForeignKey("[AS].[DECISION]", "CODIGO_DECISION"), LeftJoin("jExcentoSeguro2"), TextualField("ExcentoSeguro2NombreDecision")]
        public String ExcentoSeguro2
        {
            get { return Fields.ExcentoSeguro2[this]; }
            set { Fields.ExcentoSeguro2[this] = value; }
        }

        [DisplayName("Excento Seguro3"), Column("EXCENTO_SEGURO3"), Size(1), NotNull, ForeignKey("[AS].[DECISION]", "CODIGO_DECISION"), LeftJoin("jExcentoSeguro3"), TextualField("ExcentoSeguro3NombreDecision")]
        public String ExcentoSeguro3
        {
            get { return Fields.ExcentoSeguro3[this]; }
            set { Fields.ExcentoSeguro3[this] = value; }
        }

        [DisplayName("Esmora"), Column("ESMORA"), Size(1), NotNull, ForeignKey("[AS].[DECISION]", "CODIGO_DECISION"), LeftJoin("jEsmora"), TextualField("EsmoraNombreDecision")]
        public String Esmora
        {
            get { return Fields.Esmora[this]; }
            set { Fields.Esmora[this] = value; }
        }

        [DisplayName("Esinicio"), Column("ESINICIO"), Size(1), NotNull, ForeignKey("[AS].[DECISION]", "CODIGO_DECISION"), LeftJoin("jEsinicio"), TextualField("EsinicioNombreDecision")]
        public String Esinicio
        {
            get { return Fields.Esinicio[this]; }
            set { Fields.Esinicio[this] = value; }
        }

        [DisplayName("Esfin"), Column("ESFIN"), Size(1), NotNull, ForeignKey("[AS].[DECISION]", "CODIGO_DECISION"), LeftJoin("jEsfin"), TextualField("EsfinNombreDecision")]
        public String Esfin
        {
            get { return Fields.Esfin[this]; }
            set { Fields.Esfin[this] = value; }
        }

        [DisplayName("Estransaccional"), Column("ESTRANSACCIONAL"), Size(1), NotNull, ForeignKey("[AS].[DECISION]", "CODIGO_DECISION"), LeftJoin("jEstransaccional"), TextualField("EstransaccionalNombreDecision")]
        public String Estransaccional
        {
            get { return Fields.Estransaccional[this]; }
            set { Fields.Estransaccional[this] = value; }
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

        [DisplayName("Ip Cliente"), Column("IP_CLIENTE"), Size(50)]
        public String IpCliente
        {
            get { return Fields.IpCliente[this]; }
            set { Fields.IpCliente[this] = value; }
        }

        [DisplayName("Aplicacion Origen"), Column("APLICACION_ORIGEN"), Size(50)]
        public String AplicacionOrigen
        {
            get { return Fields.AplicacionOrigen[this]; }
            set { Fields.AplicacionOrigen[this] = value; }
        }

        [DisplayName("Host Cliente"), Column("HOST_CLIENTE"), Size(50)]
        public String HostCliente
        {
            get { return Fields.HostCliente[this]; }
            set { Fields.HostCliente[this] = value; }
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

        [DisplayName("Codigo Estado Nombre"), Expression("jCodigoEstado.[NOMBRE]")]
        public String CodigoEstadoNombre
        {
            get { return Fields.CodigoEstadoNombre[this]; }
            set { Fields.CodigoEstadoNombre[this] = value; }
        }

        [DisplayName("Codigo Estado Codigo Modulo"), Expression("jCodigoEstado.[CODIGO_MODULO]")]
        public String CodigoEstadoCodigoModulo
        {
            get { return Fields.CodigoEstadoCodigoModulo[this]; }
            set { Fields.CodigoEstadoCodigoModulo[this] = value; }
        }

        [DisplayName("Codigo Estado Tabla"), Expression("jCodigoEstado.[TABLA]")]
        public String CodigoEstadoTabla
        {
            get { return Fields.CodigoEstadoTabla[this]; }
            set { Fields.CodigoEstadoTabla[this] = value; }
        }

        [DisplayName("Codigo Estado Secuencia"), Expression("jCodigoEstado.[SECUENCIA]")]
        public Int64? CodigoEstadoSecuencia
        {
            get { return Fields.CodigoEstadoSecuencia[this]; }
            set { Fields.CodigoEstadoSecuencia[this] = value; }
        }

        [DisplayName("Codigo Estado Excento Interes Diario"), Expression("jCodigoEstado.[EXCENTO_INTERES_DIARIO]")]
        public String CodigoEstadoExcentoInteresDiario
        {
            get { return Fields.CodigoEstadoExcentoInteresDiario[this]; }
            set { Fields.CodigoEstadoExcentoInteresDiario[this] = value; }
        }

        [DisplayName("Codigo Estado Excento Interes Mora"), Expression("jCodigoEstado.[EXCENTO_INTERES_MORA]")]
        public String CodigoEstadoExcentoInteresMora
        {
            get { return Fields.CodigoEstadoExcentoInteresMora[this]; }
            set { Fields.CodigoEstadoExcentoInteresMora[this] = value; }
        }

        [DisplayName("Codigo Estado Excento Seguro1"), Expression("jCodigoEstado.[EXCENTO_SEGURO1]")]
        public String CodigoEstadoExcentoSeguro1
        {
            get { return Fields.CodigoEstadoExcentoSeguro1[this]; }
            set { Fields.CodigoEstadoExcentoSeguro1[this] = value; }
        }

        [DisplayName("Codigo Estado Excento Seguro2"), Expression("jCodigoEstado.[EXCENTO_SEGURO2]")]
        public String CodigoEstadoExcentoSeguro2
        {
            get { return Fields.CodigoEstadoExcentoSeguro2[this]; }
            set { Fields.CodigoEstadoExcentoSeguro2[this] = value; }
        }

        [DisplayName("Codigo Estado Excento Seguro3"), Expression("jCodigoEstado.[EXCENTO_SEGURO3]")]
        public String CodigoEstadoExcentoSeguro3
        {
            get { return Fields.CodigoEstadoExcentoSeguro3[this]; }
            set { Fields.CodigoEstadoExcentoSeguro3[this] = value; }
        }

        [DisplayName("Codigo Estado Esmora"), Expression("jCodigoEstado.[ESMORA]")]
        public String CodigoEstadoEsmora
        {
            get { return Fields.CodigoEstadoEsmora[this]; }
            set { Fields.CodigoEstadoEsmora[this] = value; }
        }

        [DisplayName("Codigo Estado Esinicio"), Expression("jCodigoEstado.[ESINICIO]")]
        public String CodigoEstadoEsinicio
        {
            get { return Fields.CodigoEstadoEsinicio[this]; }
            set { Fields.CodigoEstadoEsinicio[this] = value; }
        }

        [DisplayName("Codigo Estado Esfin"), Expression("jCodigoEstado.[ESFIN]")]
        public String CodigoEstadoEsfin
        {
            get { return Fields.CodigoEstadoEsfin[this]; }
            set { Fields.CodigoEstadoEsfin[this] = value; }
        }

        [DisplayName("Codigo Estado Estransaccional"), Expression("jCodigoEstado.[ESTRANSACCIONAL]")]
        public String CodigoEstadoEstransaccional
        {
            get { return Fields.CodigoEstadoEstransaccional[this]; }
            set { Fields.CodigoEstadoEstransaccional[this] = value; }
        }

        [DisplayName("Codigo Estado Fecha Creacion"), Expression("jCodigoEstado.[FECHA_CREACION]")]
        public DateTime? CodigoEstadoFechaCreacion
        {
            get { return Fields.CodigoEstadoFechaCreacion[this]; }
            set { Fields.CodigoEstadoFechaCreacion[this] = value; }
        }

        [DisplayName("Codigo Estado Fecha Modificacion"), Expression("jCodigoEstado.[FECHA_MODIFICACION]")]
        public DateTime? CodigoEstadoFechaModificacion
        {
            get { return Fields.CodigoEstadoFechaModificacion[this]; }
            set { Fields.CodigoEstadoFechaModificacion[this] = value; }
        }

        [DisplayName("Codigo Estado Creado Por"), Expression("jCodigoEstado.[CREADO_POR]")]
        public String CodigoEstadoCreadoPor
        {
            get { return Fields.CodigoEstadoCreadoPor[this]; }
            set { Fields.CodigoEstadoCreadoPor[this] = value; }
        }

        [DisplayName("Codigo Estado Modificado Por"), Expression("jCodigoEstado.[MODIFICADO_POR]")]
        public String CodigoEstadoModificadoPor
        {
            get { return Fields.CodigoEstadoModificadoPor[this]; }
            set { Fields.CodigoEstadoModificadoPor[this] = value; }
        }

        [DisplayName("Codigo Estado Ip Cliente"), Expression("jCodigoEstado.[IP_CLIENTE]")]
        public String CodigoEstadoIpCliente
        {
            get { return Fields.CodigoEstadoIpCliente[this]; }
            set { Fields.CodigoEstadoIpCliente[this] = value; }
        }

        [DisplayName("Codigo Estado Aplicacion Origen"), Expression("jCodigoEstado.[APLICACION_ORIGEN]")]
        public String CodigoEstadoAplicacionOrigen
        {
            get { return Fields.CodigoEstadoAplicacionOrigen[this]; }
            set { Fields.CodigoEstadoAplicacionOrigen[this] = value; }
        }

        [DisplayName("Codigo Estado Host Cliente"), Expression("jCodigoEstado.[HOST_CLIENTE]")]
        public String CodigoEstadoHostCliente
        {
            get { return Fields.CodigoEstadoHostCliente[this]; }
            set { Fields.CodigoEstadoHostCliente[this] = value; }
        }

        [DisplayName("Codigo Estado Activo"), Expression("jCodigoEstado.[ACTIVO]")]
        public Int32? CodigoEstadoActivo
        {
            get { return Fields.CodigoEstadoActivo[this]; }
            set { Fields.CodigoEstadoActivo[this] = value; }
        }

        [DisplayName("Codigo Estado Visible"), Expression("jCodigoEstado.[VISIBLE]")]
        public Boolean? CodigoEstadoVisible
        {
            get { return Fields.CodigoEstadoVisible[this]; }
            set { Fields.CodigoEstadoVisible[this] = value; }
        }

        [DisplayName("Codigo Estado Permitido"), Expression("jCodigoEstado.[PERMITIDO]")]
        public Boolean? CodigoEstadoPermitido
        {
            get { return Fields.CodigoEstadoPermitido[this]; }
            set { Fields.CodigoEstadoPermitido[this] = value; }
        }

        [DisplayName("Codigo Modulo Nombre Modulo"), Expression("jCodigoModulo.[NOMBRE_MODULO]")]
        public String CodigoModuloNombreModulo
        {
            get { return Fields.CodigoModuloNombreModulo[this]; }
            set { Fields.CodigoModuloNombreModulo[this] = value; }
        }

        [DisplayName("Codigo Modulo Protocolo"), Expression("jCodigoModulo.[PROTOCOLO]")]
        public String CodigoModuloProtocolo
        {
            get { return Fields.CodigoModuloProtocolo[this]; }
            set { Fields.CodigoModuloProtocolo[this] = value; }
        }

        [DisplayName("Codigo Modulo Separador Puerto"), Expression("jCodigoModulo.[SEPARADOR_PUERTO]")]
        public String CodigoModuloSeparadorPuerto
        {
            get { return Fields.CodigoModuloSeparadorPuerto[this]; }
            set { Fields.CodigoModuloSeparadorPuerto[this] = value; }
        }

        [DisplayName("Codigo Modulo Puerto"), Expression("jCodigoModulo.[PUERTO]")]
        public String CodigoModuloPuerto
        {
            get { return Fields.CodigoModuloPuerto[this]; }
            set { Fields.CodigoModuloPuerto[this] = value; }
        }

        [DisplayName("Codigo Modulo Servidor"), Expression("jCodigoModulo.[SERVIDOR]")]
        public String CodigoModuloServidor
        {
            get { return Fields.CodigoModuloServidor[this]; }
            set { Fields.CodigoModuloServidor[this] = value; }
        }

        [DisplayName("Excento Interes Diario Nombre Decision"), Expression("jExcentoInteresDiario.[NOMBRE_DECISION]")]
        public String ExcentoInteresDiarioNombreDecision
        {
            get { return Fields.ExcentoInteresDiarioNombreDecision[this]; }
            set { Fields.ExcentoInteresDiarioNombreDecision[this] = value; }
        }

        [DisplayName("Excento Interes Diario Fecha Creacion"), Expression("jExcentoInteresDiario.[FECHA_CREACION]")]
        public DateTime? ExcentoInteresDiarioFechaCreacion
        {
            get { return Fields.ExcentoInteresDiarioFechaCreacion[this]; }
            set { Fields.ExcentoInteresDiarioFechaCreacion[this] = value; }
        }

        [DisplayName("Excento Interes Diario Fecha Modificacion"), Expression("jExcentoInteresDiario.[FECHA_MODIFICACION]")]
        public DateTime? ExcentoInteresDiarioFechaModificacion
        {
            get { return Fields.ExcentoInteresDiarioFechaModificacion[this]; }
            set { Fields.ExcentoInteresDiarioFechaModificacion[this] = value; }
        }

        [DisplayName("Excento Interes Diario Creado Por"), Expression("jExcentoInteresDiario.[CREADO_POR]")]
        public String ExcentoInteresDiarioCreadoPor
        {
            get { return Fields.ExcentoInteresDiarioCreadoPor[this]; }
            set { Fields.ExcentoInteresDiarioCreadoPor[this] = value; }
        }

        [DisplayName("Excento Interes Diario Modificado Por"), Expression("jExcentoInteresDiario.[MODIFICADO_POR]")]
        public String ExcentoInteresDiarioModificadoPor
        {
            get { return Fields.ExcentoInteresDiarioModificadoPor[this]; }
            set { Fields.ExcentoInteresDiarioModificadoPor[this] = value; }
        }

        [DisplayName("Excento Interes Diario Ip Cliente"), Expression("jExcentoInteresDiario.[IP_CLIENTE]")]
        public String ExcentoInteresDiarioIpCliente
        {
            get { return Fields.ExcentoInteresDiarioIpCliente[this]; }
            set { Fields.ExcentoInteresDiarioIpCliente[this] = value; }
        }

        [DisplayName("Excento Interes Diario Aplicacion Origen"), Expression("jExcentoInteresDiario.[APLICACION_ORIGEN]")]
        public String ExcentoInteresDiarioAplicacionOrigen
        {
            get { return Fields.ExcentoInteresDiarioAplicacionOrigen[this]; }
            set { Fields.ExcentoInteresDiarioAplicacionOrigen[this] = value; }
        }

        [DisplayName("Excento Interes Diario Host Cliente"), Expression("jExcentoInteresDiario.[HOST_CLIENTE]")]
        public String ExcentoInteresDiarioHostCliente
        {
            get { return Fields.ExcentoInteresDiarioHostCliente[this]; }
            set { Fields.ExcentoInteresDiarioHostCliente[this] = value; }
        }

        [DisplayName("Excento Interes Diario Activo"), Expression("jExcentoInteresDiario.[ACTIVO]")]
        public Int32? ExcentoInteresDiarioActivo
        {
            get { return Fields.ExcentoInteresDiarioActivo[this]; }
            set { Fields.ExcentoInteresDiarioActivo[this] = value; }
        }

        [DisplayName("Excento Interes Diario Visible"), Expression("jExcentoInteresDiario.[VISIBLE]")]
        public Boolean? ExcentoInteresDiarioVisible
        {
            get { return Fields.ExcentoInteresDiarioVisible[this]; }
            set { Fields.ExcentoInteresDiarioVisible[this] = value; }
        }

        [DisplayName("Excento Interes Diario Permitido"), Expression("jExcentoInteresDiario.[PERMITIDO]")]
        public Boolean? ExcentoInteresDiarioPermitido
        {
            get { return Fields.ExcentoInteresDiarioPermitido[this]; }
            set { Fields.ExcentoInteresDiarioPermitido[this] = value; }
        }

        [DisplayName("Excento Interes Mora Nombre Decision"), Expression("jExcentoInteresMora.[NOMBRE_DECISION]")]
        public String ExcentoInteresMoraNombreDecision
        {
            get { return Fields.ExcentoInteresMoraNombreDecision[this]; }
            set { Fields.ExcentoInteresMoraNombreDecision[this] = value; }
        }

        [DisplayName("Excento Interes Mora Fecha Creacion"), Expression("jExcentoInteresMora.[FECHA_CREACION]")]
        public DateTime? ExcentoInteresMoraFechaCreacion
        {
            get { return Fields.ExcentoInteresMoraFechaCreacion[this]; }
            set { Fields.ExcentoInteresMoraFechaCreacion[this] = value; }
        }

        [DisplayName("Excento Interes Mora Fecha Modificacion"), Expression("jExcentoInteresMora.[FECHA_MODIFICACION]")]
        public DateTime? ExcentoInteresMoraFechaModificacion
        {
            get { return Fields.ExcentoInteresMoraFechaModificacion[this]; }
            set { Fields.ExcentoInteresMoraFechaModificacion[this] = value; }
        }

        [DisplayName("Excento Interes Mora Creado Por"), Expression("jExcentoInteresMora.[CREADO_POR]")]
        public String ExcentoInteresMoraCreadoPor
        {
            get { return Fields.ExcentoInteresMoraCreadoPor[this]; }
            set { Fields.ExcentoInteresMoraCreadoPor[this] = value; }
        }

        [DisplayName("Excento Interes Mora Modificado Por"), Expression("jExcentoInteresMora.[MODIFICADO_POR]")]
        public String ExcentoInteresMoraModificadoPor
        {
            get { return Fields.ExcentoInteresMoraModificadoPor[this]; }
            set { Fields.ExcentoInteresMoraModificadoPor[this] = value; }
        }

        [DisplayName("Excento Interes Mora Ip Cliente"), Expression("jExcentoInteresMora.[IP_CLIENTE]")]
        public String ExcentoInteresMoraIpCliente
        {
            get { return Fields.ExcentoInteresMoraIpCliente[this]; }
            set { Fields.ExcentoInteresMoraIpCliente[this] = value; }
        }

        [DisplayName("Excento Interes Mora Aplicacion Origen"), Expression("jExcentoInteresMora.[APLICACION_ORIGEN]")]
        public String ExcentoInteresMoraAplicacionOrigen
        {
            get { return Fields.ExcentoInteresMoraAplicacionOrigen[this]; }
            set { Fields.ExcentoInteresMoraAplicacionOrigen[this] = value; }
        }

        [DisplayName("Excento Interes Mora Host Cliente"), Expression("jExcentoInteresMora.[HOST_CLIENTE]")]
        public String ExcentoInteresMoraHostCliente
        {
            get { return Fields.ExcentoInteresMoraHostCliente[this]; }
            set { Fields.ExcentoInteresMoraHostCliente[this] = value; }
        }

        [DisplayName("Excento Interes Mora Activo"), Expression("jExcentoInteresMora.[ACTIVO]")]
        public Int32? ExcentoInteresMoraActivo
        {
            get { return Fields.ExcentoInteresMoraActivo[this]; }
            set { Fields.ExcentoInteresMoraActivo[this] = value; }
        }

        [DisplayName("Excento Interes Mora Visible"), Expression("jExcentoInteresMora.[VISIBLE]")]
        public Boolean? ExcentoInteresMoraVisible
        {
            get { return Fields.ExcentoInteresMoraVisible[this]; }
            set { Fields.ExcentoInteresMoraVisible[this] = value; }
        }

        [DisplayName("Excento Interes Mora Permitido"), Expression("jExcentoInteresMora.[PERMITIDO]")]
        public Boolean? ExcentoInteresMoraPermitido
        {
            get { return Fields.ExcentoInteresMoraPermitido[this]; }
            set { Fields.ExcentoInteresMoraPermitido[this] = value; }
        }

        [DisplayName("Excento Seguro1 Nombre Decision"), Expression("jExcentoSeguro1.[NOMBRE_DECISION]")]
        public String ExcentoSeguro1NombreDecision
        {
            get { return Fields.ExcentoSeguro1NombreDecision[this]; }
            set { Fields.ExcentoSeguro1NombreDecision[this] = value; }
        }

        [DisplayName("Excento Seguro1 Fecha Creacion"), Expression("jExcentoSeguro1.[FECHA_CREACION]")]
        public DateTime? ExcentoSeguro1FechaCreacion
        {
            get { return Fields.ExcentoSeguro1FechaCreacion[this]; }
            set { Fields.ExcentoSeguro1FechaCreacion[this] = value; }
        }

        [DisplayName("Excento Seguro1 Fecha Modificacion"), Expression("jExcentoSeguro1.[FECHA_MODIFICACION]")]
        public DateTime? ExcentoSeguro1FechaModificacion
        {
            get { return Fields.ExcentoSeguro1FechaModificacion[this]; }
            set { Fields.ExcentoSeguro1FechaModificacion[this] = value; }
        }

        [DisplayName("Excento Seguro1 Creado Por"), Expression("jExcentoSeguro1.[CREADO_POR]")]
        public String ExcentoSeguro1CreadoPor
        {
            get { return Fields.ExcentoSeguro1CreadoPor[this]; }
            set { Fields.ExcentoSeguro1CreadoPor[this] = value; }
        }

        [DisplayName("Excento Seguro1 Modificado Por"), Expression("jExcentoSeguro1.[MODIFICADO_POR]")]
        public String ExcentoSeguro1ModificadoPor
        {
            get { return Fields.ExcentoSeguro1ModificadoPor[this]; }
            set { Fields.ExcentoSeguro1ModificadoPor[this] = value; }
        }

        [DisplayName("Excento Seguro1 Ip Cliente"), Expression("jExcentoSeguro1.[IP_CLIENTE]")]
        public String ExcentoSeguro1IpCliente
        {
            get { return Fields.ExcentoSeguro1IpCliente[this]; }
            set { Fields.ExcentoSeguro1IpCliente[this] = value; }
        }

        [DisplayName("Excento Seguro1 Aplicacion Origen"), Expression("jExcentoSeguro1.[APLICACION_ORIGEN]")]
        public String ExcentoSeguro1AplicacionOrigen
        {
            get { return Fields.ExcentoSeguro1AplicacionOrigen[this]; }
            set { Fields.ExcentoSeguro1AplicacionOrigen[this] = value; }
        }

        [DisplayName("Excento Seguro1 Host Cliente"), Expression("jExcentoSeguro1.[HOST_CLIENTE]")]
        public String ExcentoSeguro1HostCliente
        {
            get { return Fields.ExcentoSeguro1HostCliente[this]; }
            set { Fields.ExcentoSeguro1HostCliente[this] = value; }
        }

        [DisplayName("Excento Seguro1 Activo"), Expression("jExcentoSeguro1.[ACTIVO]")]
        public Int32? ExcentoSeguro1Activo
        {
            get { return Fields.ExcentoSeguro1Activo[this]; }
            set { Fields.ExcentoSeguro1Activo[this] = value; }
        }

        [DisplayName("Excento Seguro1 Visible"), Expression("jExcentoSeguro1.[VISIBLE]")]
        public Boolean? ExcentoSeguro1Visible
        {
            get { return Fields.ExcentoSeguro1Visible[this]; }
            set { Fields.ExcentoSeguro1Visible[this] = value; }
        }

        [DisplayName("Excento Seguro1 Permitido"), Expression("jExcentoSeguro1.[PERMITIDO]")]
        public Boolean? ExcentoSeguro1Permitido
        {
            get { return Fields.ExcentoSeguro1Permitido[this]; }
            set { Fields.ExcentoSeguro1Permitido[this] = value; }
        }

        [DisplayName("Excento Seguro2 Nombre Decision"), Expression("jExcentoSeguro2.[NOMBRE_DECISION]")]
        public String ExcentoSeguro2NombreDecision
        {
            get { return Fields.ExcentoSeguro2NombreDecision[this]; }
            set { Fields.ExcentoSeguro2NombreDecision[this] = value; }
        }

        [DisplayName("Excento Seguro2 Fecha Creacion"), Expression("jExcentoSeguro2.[FECHA_CREACION]")]
        public DateTime? ExcentoSeguro2FechaCreacion
        {
            get { return Fields.ExcentoSeguro2FechaCreacion[this]; }
            set { Fields.ExcentoSeguro2FechaCreacion[this] = value; }
        }

        [DisplayName("Excento Seguro2 Fecha Modificacion"), Expression("jExcentoSeguro2.[FECHA_MODIFICACION]")]
        public DateTime? ExcentoSeguro2FechaModificacion
        {
            get { return Fields.ExcentoSeguro2FechaModificacion[this]; }
            set { Fields.ExcentoSeguro2FechaModificacion[this] = value; }
        }

        [DisplayName("Excento Seguro2 Creado Por"), Expression("jExcentoSeguro2.[CREADO_POR]")]
        public String ExcentoSeguro2CreadoPor
        {
            get { return Fields.ExcentoSeguro2CreadoPor[this]; }
            set { Fields.ExcentoSeguro2CreadoPor[this] = value; }
        }

        [DisplayName("Excento Seguro2 Modificado Por"), Expression("jExcentoSeguro2.[MODIFICADO_POR]")]
        public String ExcentoSeguro2ModificadoPor
        {
            get { return Fields.ExcentoSeguro2ModificadoPor[this]; }
            set { Fields.ExcentoSeguro2ModificadoPor[this] = value; }
        }

        [DisplayName("Excento Seguro2 Ip Cliente"), Expression("jExcentoSeguro2.[IP_CLIENTE]")]
        public String ExcentoSeguro2IpCliente
        {
            get { return Fields.ExcentoSeguro2IpCliente[this]; }
            set { Fields.ExcentoSeguro2IpCliente[this] = value; }
        }

        [DisplayName("Excento Seguro2 Aplicacion Origen"), Expression("jExcentoSeguro2.[APLICACION_ORIGEN]")]
        public String ExcentoSeguro2AplicacionOrigen
        {
            get { return Fields.ExcentoSeguro2AplicacionOrigen[this]; }
            set { Fields.ExcentoSeguro2AplicacionOrigen[this] = value; }
        }

        [DisplayName("Excento Seguro2 Host Cliente"), Expression("jExcentoSeguro2.[HOST_CLIENTE]")]
        public String ExcentoSeguro2HostCliente
        {
            get { return Fields.ExcentoSeguro2HostCliente[this]; }
            set { Fields.ExcentoSeguro2HostCliente[this] = value; }
        }

        [DisplayName("Excento Seguro2 Activo"), Expression("jExcentoSeguro2.[ACTIVO]")]
        public Int32? ExcentoSeguro2Activo
        {
            get { return Fields.ExcentoSeguro2Activo[this]; }
            set { Fields.ExcentoSeguro2Activo[this] = value; }
        }

        [DisplayName("Excento Seguro2 Visible"), Expression("jExcentoSeguro2.[VISIBLE]")]
        public Boolean? ExcentoSeguro2Visible
        {
            get { return Fields.ExcentoSeguro2Visible[this]; }
            set { Fields.ExcentoSeguro2Visible[this] = value; }
        }

        [DisplayName("Excento Seguro2 Permitido"), Expression("jExcentoSeguro2.[PERMITIDO]")]
        public Boolean? ExcentoSeguro2Permitido
        {
            get { return Fields.ExcentoSeguro2Permitido[this]; }
            set { Fields.ExcentoSeguro2Permitido[this] = value; }
        }

        [DisplayName("Excento Seguro3 Nombre Decision"), Expression("jExcentoSeguro3.[NOMBRE_DECISION]")]
        public String ExcentoSeguro3NombreDecision
        {
            get { return Fields.ExcentoSeguro3NombreDecision[this]; }
            set { Fields.ExcentoSeguro3NombreDecision[this] = value; }
        }

        [DisplayName("Excento Seguro3 Fecha Creacion"), Expression("jExcentoSeguro3.[FECHA_CREACION]")]
        public DateTime? ExcentoSeguro3FechaCreacion
        {
            get { return Fields.ExcentoSeguro3FechaCreacion[this]; }
            set { Fields.ExcentoSeguro3FechaCreacion[this] = value; }
        }

        [DisplayName("Excento Seguro3 Fecha Modificacion"), Expression("jExcentoSeguro3.[FECHA_MODIFICACION]")]
        public DateTime? ExcentoSeguro3FechaModificacion
        {
            get { return Fields.ExcentoSeguro3FechaModificacion[this]; }
            set { Fields.ExcentoSeguro3FechaModificacion[this] = value; }
        }

        [DisplayName("Excento Seguro3 Creado Por"), Expression("jExcentoSeguro3.[CREADO_POR]")]
        public String ExcentoSeguro3CreadoPor
        {
            get { return Fields.ExcentoSeguro3CreadoPor[this]; }
            set { Fields.ExcentoSeguro3CreadoPor[this] = value; }
        }

        [DisplayName("Excento Seguro3 Modificado Por"), Expression("jExcentoSeguro3.[MODIFICADO_POR]")]
        public String ExcentoSeguro3ModificadoPor
        {
            get { return Fields.ExcentoSeguro3ModificadoPor[this]; }
            set { Fields.ExcentoSeguro3ModificadoPor[this] = value; }
        }

        [DisplayName("Excento Seguro3 Ip Cliente"), Expression("jExcentoSeguro3.[IP_CLIENTE]")]
        public String ExcentoSeguro3IpCliente
        {
            get { return Fields.ExcentoSeguro3IpCliente[this]; }
            set { Fields.ExcentoSeguro3IpCliente[this] = value; }
        }

        [DisplayName("Excento Seguro3 Aplicacion Origen"), Expression("jExcentoSeguro3.[APLICACION_ORIGEN]")]
        public String ExcentoSeguro3AplicacionOrigen
        {
            get { return Fields.ExcentoSeguro3AplicacionOrigen[this]; }
            set { Fields.ExcentoSeguro3AplicacionOrigen[this] = value; }
        }

        [DisplayName("Excento Seguro3 Host Cliente"), Expression("jExcentoSeguro3.[HOST_CLIENTE]")]
        public String ExcentoSeguro3HostCliente
        {
            get { return Fields.ExcentoSeguro3HostCliente[this]; }
            set { Fields.ExcentoSeguro3HostCliente[this] = value; }
        }

        [DisplayName("Excento Seguro3 Activo"), Expression("jExcentoSeguro3.[ACTIVO]")]
        public Int32? ExcentoSeguro3Activo
        {
            get { return Fields.ExcentoSeguro3Activo[this]; }
            set { Fields.ExcentoSeguro3Activo[this] = value; }
        }

        [DisplayName("Excento Seguro3 Visible"), Expression("jExcentoSeguro3.[VISIBLE]")]
        public Boolean? ExcentoSeguro3Visible
        {
            get { return Fields.ExcentoSeguro3Visible[this]; }
            set { Fields.ExcentoSeguro3Visible[this] = value; }
        }

        [DisplayName("Excento Seguro3 Permitido"), Expression("jExcentoSeguro3.[PERMITIDO]")]
        public Boolean? ExcentoSeguro3Permitido
        {
            get { return Fields.ExcentoSeguro3Permitido[this]; }
            set { Fields.ExcentoSeguro3Permitido[this] = value; }
        }

        [DisplayName("Esmora Nombre Decision"), Expression("jEsmora.[NOMBRE_DECISION]")]
        public String EsmoraNombreDecision
        {
            get { return Fields.EsmoraNombreDecision[this]; }
            set { Fields.EsmoraNombreDecision[this] = value; }
        }

        [DisplayName("Esmora Fecha Creacion"), Expression("jEsmora.[FECHA_CREACION]")]
        public DateTime? EsmoraFechaCreacion
        {
            get { return Fields.EsmoraFechaCreacion[this]; }
            set { Fields.EsmoraFechaCreacion[this] = value; }
        }

        [DisplayName("Esmora Fecha Modificacion"), Expression("jEsmora.[FECHA_MODIFICACION]")]
        public DateTime? EsmoraFechaModificacion
        {
            get { return Fields.EsmoraFechaModificacion[this]; }
            set { Fields.EsmoraFechaModificacion[this] = value; }
        }

        [DisplayName("Esmora Creado Por"), Expression("jEsmora.[CREADO_POR]")]
        public String EsmoraCreadoPor
        {
            get { return Fields.EsmoraCreadoPor[this]; }
            set { Fields.EsmoraCreadoPor[this] = value; }
        }

        [DisplayName("Esmora Modificado Por"), Expression("jEsmora.[MODIFICADO_POR]")]
        public String EsmoraModificadoPor
        {
            get { return Fields.EsmoraModificadoPor[this]; }
            set { Fields.EsmoraModificadoPor[this] = value; }
        }

        [DisplayName("Esmora Ip Cliente"), Expression("jEsmora.[IP_CLIENTE]")]
        public String EsmoraIpCliente
        {
            get { return Fields.EsmoraIpCliente[this]; }
            set { Fields.EsmoraIpCliente[this] = value; }
        }

        [DisplayName("Esmora Aplicacion Origen"), Expression("jEsmora.[APLICACION_ORIGEN]")]
        public String EsmoraAplicacionOrigen
        {
            get { return Fields.EsmoraAplicacionOrigen[this]; }
            set { Fields.EsmoraAplicacionOrigen[this] = value; }
        }

        [DisplayName("Esmora Host Cliente"), Expression("jEsmora.[HOST_CLIENTE]")]
        public String EsmoraHostCliente
        {
            get { return Fields.EsmoraHostCliente[this]; }
            set { Fields.EsmoraHostCliente[this] = value; }
        }

        [DisplayName("Esmora Activo"), Expression("jEsmora.[ACTIVO]")]
        public Int32? EsmoraActivo
        {
            get { return Fields.EsmoraActivo[this]; }
            set { Fields.EsmoraActivo[this] = value; }
        }

        [DisplayName("Esmora Visible"), Expression("jEsmora.[VISIBLE]")]
        public Boolean? EsmoraVisible
        {
            get { return Fields.EsmoraVisible[this]; }
            set { Fields.EsmoraVisible[this] = value; }
        }

        [DisplayName("Esmora Permitido"), Expression("jEsmora.[PERMITIDO]")]
        public Boolean? EsmoraPermitido
        {
            get { return Fields.EsmoraPermitido[this]; }
            set { Fields.EsmoraPermitido[this] = value; }
        }

        [DisplayName("Esinicio Nombre Decision"), Expression("jEsinicio.[NOMBRE_DECISION]")]
        public String EsinicioNombreDecision
        {
            get { return Fields.EsinicioNombreDecision[this]; }
            set { Fields.EsinicioNombreDecision[this] = value; }
        }

        [DisplayName("Esinicio Fecha Creacion"), Expression("jEsinicio.[FECHA_CREACION]")]
        public DateTime? EsinicioFechaCreacion
        {
            get { return Fields.EsinicioFechaCreacion[this]; }
            set { Fields.EsinicioFechaCreacion[this] = value; }
        }

        [DisplayName("Esinicio Fecha Modificacion"), Expression("jEsinicio.[FECHA_MODIFICACION]")]
        public DateTime? EsinicioFechaModificacion
        {
            get { return Fields.EsinicioFechaModificacion[this]; }
            set { Fields.EsinicioFechaModificacion[this] = value; }
        }

        [DisplayName("Esinicio Creado Por"), Expression("jEsinicio.[CREADO_POR]")]
        public String EsinicioCreadoPor
        {
            get { return Fields.EsinicioCreadoPor[this]; }
            set { Fields.EsinicioCreadoPor[this] = value; }
        }

        [DisplayName("Esinicio Modificado Por"), Expression("jEsinicio.[MODIFICADO_POR]")]
        public String EsinicioModificadoPor
        {
            get { return Fields.EsinicioModificadoPor[this]; }
            set { Fields.EsinicioModificadoPor[this] = value; }
        }

        [DisplayName("Esinicio Ip Cliente"), Expression("jEsinicio.[IP_CLIENTE]")]
        public String EsinicioIpCliente
        {
            get { return Fields.EsinicioIpCliente[this]; }
            set { Fields.EsinicioIpCliente[this] = value; }
        }

        [DisplayName("Esinicio Aplicacion Origen"), Expression("jEsinicio.[APLICACION_ORIGEN]")]
        public String EsinicioAplicacionOrigen
        {
            get { return Fields.EsinicioAplicacionOrigen[this]; }
            set { Fields.EsinicioAplicacionOrigen[this] = value; }
        }

        [DisplayName("Esinicio Host Cliente"), Expression("jEsinicio.[HOST_CLIENTE]")]
        public String EsinicioHostCliente
        {
            get { return Fields.EsinicioHostCliente[this]; }
            set { Fields.EsinicioHostCliente[this] = value; }
        }

        [DisplayName("Esinicio Activo"), Expression("jEsinicio.[ACTIVO]")]
        public Int32? EsinicioActivo
        {
            get { return Fields.EsinicioActivo[this]; }
            set { Fields.EsinicioActivo[this] = value; }
        }

        [DisplayName("Esinicio Visible"), Expression("jEsinicio.[VISIBLE]")]
        public Boolean? EsinicioVisible
        {
            get { return Fields.EsinicioVisible[this]; }
            set { Fields.EsinicioVisible[this] = value; }
        }

        [DisplayName("Esinicio Permitido"), Expression("jEsinicio.[PERMITIDO]")]
        public Boolean? EsinicioPermitido
        {
            get { return Fields.EsinicioPermitido[this]; }
            set { Fields.EsinicioPermitido[this] = value; }
        }

        [DisplayName("Esfin Nombre Decision"), Expression("jEsfin.[NOMBRE_DECISION]")]
        public String EsfinNombreDecision
        {
            get { return Fields.EsfinNombreDecision[this]; }
            set { Fields.EsfinNombreDecision[this] = value; }
        }

        [DisplayName("Esfin Fecha Creacion"), Expression("jEsfin.[FECHA_CREACION]")]
        public DateTime? EsfinFechaCreacion
        {
            get { return Fields.EsfinFechaCreacion[this]; }
            set { Fields.EsfinFechaCreacion[this] = value; }
        }

        [DisplayName("Esfin Fecha Modificacion"), Expression("jEsfin.[FECHA_MODIFICACION]")]
        public DateTime? EsfinFechaModificacion
        {
            get { return Fields.EsfinFechaModificacion[this]; }
            set { Fields.EsfinFechaModificacion[this] = value; }
        }

        [DisplayName("Esfin Creado Por"), Expression("jEsfin.[CREADO_POR]")]
        public String EsfinCreadoPor
        {
            get { return Fields.EsfinCreadoPor[this]; }
            set { Fields.EsfinCreadoPor[this] = value; }
        }

        [DisplayName("Esfin Modificado Por"), Expression("jEsfin.[MODIFICADO_POR]")]
        public String EsfinModificadoPor
        {
            get { return Fields.EsfinModificadoPor[this]; }
            set { Fields.EsfinModificadoPor[this] = value; }
        }

        [DisplayName("Esfin Ip Cliente"), Expression("jEsfin.[IP_CLIENTE]")]
        public String EsfinIpCliente
        {
            get { return Fields.EsfinIpCliente[this]; }
            set { Fields.EsfinIpCliente[this] = value; }
        }

        [DisplayName("Esfin Aplicacion Origen"), Expression("jEsfin.[APLICACION_ORIGEN]")]
        public String EsfinAplicacionOrigen
        {
            get { return Fields.EsfinAplicacionOrigen[this]; }
            set { Fields.EsfinAplicacionOrigen[this] = value; }
        }

        [DisplayName("Esfin Host Cliente"), Expression("jEsfin.[HOST_CLIENTE]")]
        public String EsfinHostCliente
        {
            get { return Fields.EsfinHostCliente[this]; }
            set { Fields.EsfinHostCliente[this] = value; }
        }

        [DisplayName("Esfin Activo"), Expression("jEsfin.[ACTIVO]")]
        public Int32? EsfinActivo
        {
            get { return Fields.EsfinActivo[this]; }
            set { Fields.EsfinActivo[this] = value; }
        }

        [DisplayName("Esfin Visible"), Expression("jEsfin.[VISIBLE]")]
        public Boolean? EsfinVisible
        {
            get { return Fields.EsfinVisible[this]; }
            set { Fields.EsfinVisible[this] = value; }
        }

        [DisplayName("Esfin Permitido"), Expression("jEsfin.[PERMITIDO]")]
        public Boolean? EsfinPermitido
        {
            get { return Fields.EsfinPermitido[this]; }
            set { Fields.EsfinPermitido[this] = value; }
        }

        [DisplayName("Estransaccional Nombre Decision"), Expression("jEstransaccional.[NOMBRE_DECISION]")]
        public String EstransaccionalNombreDecision
        {
            get { return Fields.EstransaccionalNombreDecision[this]; }
            set { Fields.EstransaccionalNombreDecision[this] = value; }
        }

        [DisplayName("Estransaccional Fecha Creacion"), Expression("jEstransaccional.[FECHA_CREACION]")]
        public DateTime? EstransaccionalFechaCreacion
        {
            get { return Fields.EstransaccionalFechaCreacion[this]; }
            set { Fields.EstransaccionalFechaCreacion[this] = value; }
        }

        [DisplayName("Estransaccional Fecha Modificacion"), Expression("jEstransaccional.[FECHA_MODIFICACION]")]
        public DateTime? EstransaccionalFechaModificacion
        {
            get { return Fields.EstransaccionalFechaModificacion[this]; }
            set { Fields.EstransaccionalFechaModificacion[this] = value; }
        }

        [DisplayName("Estransaccional Creado Por"), Expression("jEstransaccional.[CREADO_POR]")]
        public String EstransaccionalCreadoPor
        {
            get { return Fields.EstransaccionalCreadoPor[this]; }
            set { Fields.EstransaccionalCreadoPor[this] = value; }
        }

        [DisplayName("Estransaccional Modificado Por"), Expression("jEstransaccional.[MODIFICADO_POR]")]
        public String EstransaccionalModificadoPor
        {
            get { return Fields.EstransaccionalModificadoPor[this]; }
            set { Fields.EstransaccionalModificadoPor[this] = value; }
        }

        [DisplayName("Estransaccional Ip Cliente"), Expression("jEstransaccional.[IP_CLIENTE]")]
        public String EstransaccionalIpCliente
        {
            get { return Fields.EstransaccionalIpCliente[this]; }
            set { Fields.EstransaccionalIpCliente[this] = value; }
        }

        [DisplayName("Estransaccional Aplicacion Origen"), Expression("jEstransaccional.[APLICACION_ORIGEN]")]
        public String EstransaccionalAplicacionOrigen
        {
            get { return Fields.EstransaccionalAplicacionOrigen[this]; }
            set { Fields.EstransaccionalAplicacionOrigen[this] = value; }
        }

        [DisplayName("Estransaccional Host Cliente"), Expression("jEstransaccional.[HOST_CLIENTE]")]
        public String EstransaccionalHostCliente
        {
            get { return Fields.EstransaccionalHostCliente[this]; }
            set { Fields.EstransaccionalHostCliente[this] = value; }
        }

        [DisplayName("Estransaccional Activo"), Expression("jEstransaccional.[ACTIVO]")]
        public Int32? EstransaccionalActivo
        {
            get { return Fields.EstransaccionalActivo[this]; }
            set { Fields.EstransaccionalActivo[this] = value; }
        }

        [DisplayName("Estransaccional Visible"), Expression("jEstransaccional.[VISIBLE]")]
        public Boolean? EstransaccionalVisible
        {
            get { return Fields.EstransaccionalVisible[this]; }
            set { Fields.EstransaccionalVisible[this] = value; }
        }

        [DisplayName("Estransaccional Permitido"), Expression("jEstransaccional.[PERMITIDO]")]
        public Boolean? EstransaccionalPermitido
        {
            get { return Fields.EstransaccionalPermitido[this]; }
            set { Fields.EstransaccionalPermitido[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CodigoEstado; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CodigoEstado; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public EstadosRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField CodigoEstado;
            public StringField Nombre;
            public StringField CodigoModulo;
            public StringField Tabla;
            public Int64Field Secuencia;
            public StringField ExcentoInteresDiario;
            public StringField ExcentoInteresMora;
            public StringField ExcentoSeguro1;
            public StringField ExcentoSeguro2;
            public StringField ExcentoSeguro3;
            public StringField Esmora;
            public StringField Esinicio;
            public StringField Esfin;
            public StringField Estransaccional;
            public DateTimeField FechaCreacion;
            public DateTimeField FechaModificacion;
            public StringField CreadoPor;
            public StringField ModificadoPor;
            public StringField IpCliente;
            public StringField AplicacionOrigen;
            public StringField HostCliente;
            public Int32Field Activo;
            public BooleanField Visible;
            public BooleanField Permitido;

            public StringField CodigoEstadoNombre;
            public StringField CodigoEstadoCodigoModulo;
            public StringField CodigoEstadoTabla;
            public Int64Field CodigoEstadoSecuencia;
            public StringField CodigoEstadoExcentoInteresDiario;
            public StringField CodigoEstadoExcentoInteresMora;
            public StringField CodigoEstadoExcentoSeguro1;
            public StringField CodigoEstadoExcentoSeguro2;
            public StringField CodigoEstadoExcentoSeguro3;
            public StringField CodigoEstadoEsmora;
            public StringField CodigoEstadoEsinicio;
            public StringField CodigoEstadoEsfin;
            public StringField CodigoEstadoEstransaccional;
            public DateTimeField CodigoEstadoFechaCreacion;
            public DateTimeField CodigoEstadoFechaModificacion;
            public StringField CodigoEstadoCreadoPor;
            public StringField CodigoEstadoModificadoPor;
            public StringField CodigoEstadoIpCliente;
            public StringField CodigoEstadoAplicacionOrigen;
            public StringField CodigoEstadoHostCliente;
            public Int32Field CodigoEstadoActivo;
            public BooleanField CodigoEstadoVisible;
            public BooleanField CodigoEstadoPermitido;

            public StringField CodigoModuloNombreModulo;
            public StringField CodigoModuloProtocolo;
            public StringField CodigoModuloSeparadorPuerto;
            public StringField CodigoModuloPuerto;
            public StringField CodigoModuloServidor;

            public StringField ExcentoInteresDiarioNombreDecision;
            public DateTimeField ExcentoInteresDiarioFechaCreacion;
            public DateTimeField ExcentoInteresDiarioFechaModificacion;
            public StringField ExcentoInteresDiarioCreadoPor;
            public StringField ExcentoInteresDiarioModificadoPor;
            public StringField ExcentoInteresDiarioIpCliente;
            public StringField ExcentoInteresDiarioAplicacionOrigen;
            public StringField ExcentoInteresDiarioHostCliente;
            public Int32Field ExcentoInteresDiarioActivo;
            public BooleanField ExcentoInteresDiarioVisible;
            public BooleanField ExcentoInteresDiarioPermitido;

            public StringField ExcentoInteresMoraNombreDecision;
            public DateTimeField ExcentoInteresMoraFechaCreacion;
            public DateTimeField ExcentoInteresMoraFechaModificacion;
            public StringField ExcentoInteresMoraCreadoPor;
            public StringField ExcentoInteresMoraModificadoPor;
            public StringField ExcentoInteresMoraIpCliente;
            public StringField ExcentoInteresMoraAplicacionOrigen;
            public StringField ExcentoInteresMoraHostCliente;
            public Int32Field ExcentoInteresMoraActivo;
            public BooleanField ExcentoInteresMoraVisible;
            public BooleanField ExcentoInteresMoraPermitido;

            public StringField ExcentoSeguro1NombreDecision;
            public DateTimeField ExcentoSeguro1FechaCreacion;
            public DateTimeField ExcentoSeguro1FechaModificacion;
            public StringField ExcentoSeguro1CreadoPor;
            public StringField ExcentoSeguro1ModificadoPor;
            public StringField ExcentoSeguro1IpCliente;
            public StringField ExcentoSeguro1AplicacionOrigen;
            public StringField ExcentoSeguro1HostCliente;
            public Int32Field ExcentoSeguro1Activo;
            public BooleanField ExcentoSeguro1Visible;
            public BooleanField ExcentoSeguro1Permitido;

            public StringField ExcentoSeguro2NombreDecision;
            public DateTimeField ExcentoSeguro2FechaCreacion;
            public DateTimeField ExcentoSeguro2FechaModificacion;
            public StringField ExcentoSeguro2CreadoPor;
            public StringField ExcentoSeguro2ModificadoPor;
            public StringField ExcentoSeguro2IpCliente;
            public StringField ExcentoSeguro2AplicacionOrigen;
            public StringField ExcentoSeguro2HostCliente;
            public Int32Field ExcentoSeguro2Activo;
            public BooleanField ExcentoSeguro2Visible;
            public BooleanField ExcentoSeguro2Permitido;

            public StringField ExcentoSeguro3NombreDecision;
            public DateTimeField ExcentoSeguro3FechaCreacion;
            public DateTimeField ExcentoSeguro3FechaModificacion;
            public StringField ExcentoSeguro3CreadoPor;
            public StringField ExcentoSeguro3ModificadoPor;
            public StringField ExcentoSeguro3IpCliente;
            public StringField ExcentoSeguro3AplicacionOrigen;
            public StringField ExcentoSeguro3HostCliente;
            public Int32Field ExcentoSeguro3Activo;
            public BooleanField ExcentoSeguro3Visible;
            public BooleanField ExcentoSeguro3Permitido;

            public StringField EsmoraNombreDecision;
            public DateTimeField EsmoraFechaCreacion;
            public DateTimeField EsmoraFechaModificacion;
            public StringField EsmoraCreadoPor;
            public StringField EsmoraModificadoPor;
            public StringField EsmoraIpCliente;
            public StringField EsmoraAplicacionOrigen;
            public StringField EsmoraHostCliente;
            public Int32Field EsmoraActivo;
            public BooleanField EsmoraVisible;
            public BooleanField EsmoraPermitido;

            public StringField EsinicioNombreDecision;
            public DateTimeField EsinicioFechaCreacion;
            public DateTimeField EsinicioFechaModificacion;
            public StringField EsinicioCreadoPor;
            public StringField EsinicioModificadoPor;
            public StringField EsinicioIpCliente;
            public StringField EsinicioAplicacionOrigen;
            public StringField EsinicioHostCliente;
            public Int32Field EsinicioActivo;
            public BooleanField EsinicioVisible;
            public BooleanField EsinicioPermitido;

            public StringField EsfinNombreDecision;
            public DateTimeField EsfinFechaCreacion;
            public DateTimeField EsfinFechaModificacion;
            public StringField EsfinCreadoPor;
            public StringField EsfinModificadoPor;
            public StringField EsfinIpCliente;
            public StringField EsfinAplicacionOrigen;
            public StringField EsfinHostCliente;
            public Int32Field EsfinActivo;
            public BooleanField EsfinVisible;
            public BooleanField EsfinPermitido;

            public StringField EstransaccionalNombreDecision;
            public DateTimeField EstransaccionalFechaCreacion;
            public DateTimeField EstransaccionalFechaModificacion;
            public StringField EstransaccionalCreadoPor;
            public StringField EstransaccionalModificadoPor;
            public StringField EstransaccionalIpCliente;
            public StringField EstransaccionalAplicacionOrigen;
            public StringField EstransaccionalHostCliente;
            public Int32Field EstransaccionalActivo;
            public BooleanField EstransaccionalVisible;
            public BooleanField EstransaccionalPermitido;
        }
    }
}
