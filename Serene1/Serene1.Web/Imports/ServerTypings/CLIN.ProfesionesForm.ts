namespace Serene1.CLIN {
    export interface ProfesionesForm {
        CodigoProfesion: Serenity.StringEditor;
        CodigoAlterno: Serenity.StringEditor;
        NombreProfesion: Serenity.StringEditor;
        Puntaje: Serenity.DecimalEditor;
        Activo: Serenity.IntegerEditor;
        Visible: Serenity.BooleanEditor;
        Permitido: Serenity.BooleanEditor;
    }

    export class ProfesionesForm extends Serenity.PrefixedContext {
        static formKey = 'CLIN.Profesiones';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProfesionesForm.init)  {
                ProfesionesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(ProfesionesForm, [
                    'CodigoProfesion', w0,
                    'CodigoAlterno', w0,
                    'NombreProfesion', w0,
                    'Puntaje', w1,
                    'Activo', w2,
                    'Visible', w3,
                    'Permitido', w3
                ]);
            }
        }
    }
}

