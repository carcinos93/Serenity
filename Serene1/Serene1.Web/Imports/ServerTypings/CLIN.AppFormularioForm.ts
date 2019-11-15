namespace Serene1.CLIN {
    export interface AppFormularioForm {
        Formulario: Serenity.StringEditor;
        Titulo: Serenity.StringEditor;
        CreadoPor: Serenity.StringEditor;
        FechaCreacion: Serenity.DateEditor;
        ModificadoPor: Serenity.StringEditor;
        FechaModificacion: Serenity.DateEditor;
    }

    export class AppFormularioForm extends Serenity.PrefixedContext {
        static formKey = 'CLIN.AppFormulario';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AppFormularioForm.init)  {
                AppFormularioForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;

                Q.initFormType(AppFormularioForm, [
                    'Formulario', w0,
                    'Titulo', w0,
                    'CreadoPor', w0,
                    'FechaCreacion', w1,
                    'ModificadoPor', w0,
                    'FechaModificacion', w1
                ]);
            }
        }
    }
}

