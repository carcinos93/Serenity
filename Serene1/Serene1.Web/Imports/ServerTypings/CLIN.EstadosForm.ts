namespace Serene1.CLIN {
    export interface EstadosForm {
        Nombre: Serenity.StringEditor;
        CodigoModulo: Serenity.StringEditor;
        Tabla: Serenity.StringEditor;
        Secuencia: Serenity.StringEditor;
        ExcentoInteresDiario: Serenity.StringEditor;
        ExcentoInteresMora: Serenity.StringEditor;
        ExcentoSeguro1: Serenity.StringEditor;
        ExcentoSeguro2: Serenity.StringEditor;
        ExcentoSeguro3: Serenity.StringEditor;
        Esmora: Serenity.StringEditor;
        Esinicio: Serenity.StringEditor;
        Esfin: Serenity.StringEditor;
        Estransaccional: Serenity.StringEditor;
        FechaCreacion: Serenity.DateEditor;
        FechaModificacion: Serenity.DateEditor;
        CreadoPor: Serenity.StringEditor;
        ModificadoPor: Serenity.StringEditor;
        IpCliente: Serenity.StringEditor;
        AplicacionOrigen: Serenity.StringEditor;
        HostCliente: Serenity.StringEditor;
        Activo: Serenity.IntegerEditor;
        Visible: Serenity.BooleanEditor;
        Permitido: Serenity.BooleanEditor;
    }

    export class EstadosForm extends Serenity.PrefixedContext {
        static formKey = 'CLIN.Estados';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!EstadosForm.init)  {
                EstadosForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(EstadosForm, [
                    'Nombre', w0,
                    'CodigoModulo', w0,
                    'Tabla', w0,
                    'Secuencia', w0,
                    'ExcentoInteresDiario', w0,
                    'ExcentoInteresMora', w0,
                    'ExcentoSeguro1', w0,
                    'ExcentoSeguro2', w0,
                    'ExcentoSeguro3', w0,
                    'Esmora', w0,
                    'Esinicio', w0,
                    'Esfin', w0,
                    'Estransaccional', w0,
                    'FechaCreacion', w1,
                    'FechaModificacion', w1,
                    'CreadoPor', w0,
                    'ModificadoPor', w0,
                    'IpCliente', w0,
                    'AplicacionOrigen', w0,
                    'HostCliente', w0,
                    'Activo', w2,
                    'Visible', w3,
                    'Permitido', w3
                ]);
            }
        }
    }
}

