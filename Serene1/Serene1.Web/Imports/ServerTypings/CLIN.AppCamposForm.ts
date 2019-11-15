namespace Serene1.CLIN {
    export interface AppCamposForm {
        IdFormulario: Serenity.LookupEditor;
        Campo: Serenity.StringEditor;
        Label: Serenity.StringEditor;
        Mascara: Serenity.StringEditor;
        Longitud: Serenity.IntegerEditor;
        Tipo: Serenity.EnumEditor;
        Catalogo: Serenity.StringEditor;
        Activo: Serenity.BooleanEditor;
    }

    export class AppCamposForm extends Serenity.PrefixedContext {
        static formKey = 'CLIN.AppCampos';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AppCamposForm.init)  {
                AppCamposForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.EnumEditor;
                var w4 = s.BooleanEditor;

                Q.initFormType(AppCamposForm, [
                    'IdFormulario', w0,
                    'Campo', w1,
                    'Label', w1,
                    'Mascara', w1,
                    'Longitud', w2,
                    'Tipo', w3,
                    'Catalogo', w1,
                    'Activo', w4
                ]);
            }
        }
    }
}

