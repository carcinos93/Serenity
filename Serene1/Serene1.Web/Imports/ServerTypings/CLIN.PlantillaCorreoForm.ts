namespace Serene1.CLIN {
    export interface PlantillaCorreoForm {
        NombrePlantilla: Serenity.StringEditor;
        PerfilCorreo: Serenity.StringEditor;
        Modulo: Serenity.LookupEditor;
        Tabla: Serenity.LookupEditor;
        Campo: Serenity.StringEditor;
        Cuerpo: Serenity.HtmlContentEditor;
    }

    export class PlantillaCorreoForm extends Serenity.PrefixedContext {
        static formKey = 'DBO.PlantillaCorreo';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PlantillaCorreoForm.init)  {
                PlantillaCorreoForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.HtmlContentEditor;

                Q.initFormType(PlantillaCorreoForm, [
                    'NombrePlantilla', w0,
                    'PerfilCorreo', w0,
                    'Modulo', w1,
                    'Tabla', w1,
                    'Campo', w0,
                    'Cuerpo', w2
                ]);
            }
        }
    }
}

