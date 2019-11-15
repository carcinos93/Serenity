namespace Serene1.CLIN {
    export interface AppFormularioRow {
        Id?: string;
        Formulario?: string;
        Titulo?: string;
        CreadoPor?: string;
        FechaCreacion?: string;
        ModificadoPor?: string;
        FechaModificacion?: string;
    }

    export namespace AppFormularioRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Formulario';
        export const localTextPrefix = 'CLIN.AppFormulario';
        export const lookupKey = 'CLIN.APP_FORMULARIO';

        export function getLookup(): Q.Lookup<AppFormularioRow> {
            return Q.getLookup<AppFormularioRow>('CLIN.APP_FORMULARIO');
        }

        export declare const enum Fields {
            Id = "Id",
            Formulario = "Formulario",
            Titulo = "Titulo",
            CreadoPor = "CreadoPor",
            FechaCreacion = "FechaCreacion",
            ModificadoPor = "ModificadoPor",
            FechaModificacion = "FechaModificacion"
        }
    }
}

