namespace Serene1.CLIN {
    export interface ModuloForm {
        NombreModulo: Serenity.StringEditor;
        Protocolo: Serenity.StringEditor;
        SeparadorPuerto: Serenity.StringEditor;
        Puerto: Serenity.StringEditor;
        Servidor: Serenity.StringEditor;
    }

    export class ModuloForm extends Serenity.PrefixedContext {
        static formKey = 'DBO.Modulo';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ModuloForm.init)  {
                ModuloForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(ModuloForm, [
                    'NombreModulo', w0,
                    'Protocolo', w0,
                    'SeparadorPuerto', w0,
                    'Puerto', w0,
                    'Servidor', w0
                ]);
            }
        }
    }
}

