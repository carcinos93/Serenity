namespace Serene1.CLIN {
    export interface ProfesionesRow {
        CodigoProfesion?: string;
        CodigoAlterno?: string;
        NombreProfesion?: string;
        Puntaje?: number;
        FechaCreacion?: string;
        FechaModificacion?: string;
        CreadoPor?: string;
        ModificadoPor?: string;
        Activo?: number;
        Visible?: boolean;
        Permitido?: boolean;
    }

    export namespace ProfesionesRow {
        export const idProperty = 'CodigoProfesion';
        export const nameProperty = 'CodigoProfesion';
        export const localTextPrefix = 'CLIN.Profesiones';

        export declare const enum Fields {
            CodigoProfesion = "CodigoProfesion",
            CodigoAlterno = "CodigoAlterno",
            NombreProfesion = "NombreProfesion",
            Puntaje = "Puntaje",
            FechaCreacion = "FechaCreacion",
            FechaModificacion = "FechaModificacion",
            CreadoPor = "CreadoPor",
            ModificadoPor = "ModificadoPor",
            Activo = "Activo",
            Visible = "Visible",
            Permitido = "Permitido"
        }
    }
}

