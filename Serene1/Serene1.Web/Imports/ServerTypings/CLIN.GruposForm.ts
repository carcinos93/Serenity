namespace Serene1.CLIN {
    export interface GruposForm {
        NombreGrupo: Serenity.StringEditor;
        Activo: Serenity.StringEditor;
        FechaCreacion: Serenity.DateEditor;
        FechaModificacion: Serenity.DateEditor;
        CreadoPor: Serenity.StringEditor;
        ModificadoPor: Serenity.StringEditor;
    }

    export class GruposForm extends Serenity.PrefixedContext {
        static formKey = 'CLIN.Grupos';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!GruposForm.init)  {
                GruposForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;

                Q.initFormType(GruposForm, [
                    'NombreGrupo', w0,
                    'Activo', w0,
                    'FechaCreacion', w1,
                    'FechaModificacion', w1,
                    'CreadoPor', w0,
                    'ModificadoPor', w0
                ]);
            }
        }
    }
}

