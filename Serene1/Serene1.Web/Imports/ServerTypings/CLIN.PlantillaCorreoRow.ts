namespace Serene1.CLIN {
    export interface PlantillaCorreoRow {
        CodigoPlantilla?: string;
        NombrePlantilla?: string;
        PerfilCorreo?: string;
        Modulo?: string;
        Tabla?: string;
        Campo?: string;
        Cuerpo?: string;
        CreadoPor?: string;
        ModificadoPor?: string;
        FechaCreacion?: string;
        FechaModificacion?: string;
    }

    export namespace PlantillaCorreoRow {
        export const idProperty = 'CodigoPlantilla';
        export const nameProperty = 'CodigoPlantilla';
        export const localTextPrefix = 'CLIN.PlantillaCorreo';

        export declare const enum Fields {
            CodigoPlantilla = "CodigoPlantilla",
            NombrePlantilla = "NombrePlantilla",
            PerfilCorreo = "PerfilCorreo",
            Modulo = "Modulo",
            Tabla = "Tabla",
            Campo = "Campo",
            Cuerpo = "Cuerpo",
            CreadoPor = "CreadoPor",
            ModificadoPor = "ModificadoPor",
            FechaCreacion = "FechaCreacion",
            FechaModificacion = "FechaModificacion"
        }
    }
}

