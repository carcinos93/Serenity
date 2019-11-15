namespace Serene1.CLIN {
    export interface AppCamposRow {
        Id?: number;
        IdFormulario?: string;
        NombreFormulario?: string;
        Campo?: string;
        Label?: string;
        Mascara?: string;
        Longitud?: number;
        Tipo?: string;
        Catalogo?: string;
        Activo?: boolean;
        CreadoPor?: string;
        FechaCreacion?: string;
        ModificadoPor?: string;
        FechaModificacion?: string;
    }

    export namespace AppCamposRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Campo';
        export const localTextPrefix = 'CLIN.AppCampos';

        export declare const enum Fields {
            Id = "Id",
            IdFormulario = "IdFormulario",
            NombreFormulario = "NombreFormulario",
            Campo = "Campo",
            Label = "Label",
            Mascara = "Mascara",
            Longitud = "Longitud",
            Tipo = "Tipo",
            Catalogo = "Catalogo",
            Activo = "Activo",
            CreadoPor = "CreadoPor",
            FechaCreacion = "FechaCreacion",
            ModificadoPor = "ModificadoPor",
            FechaModificacion = "FechaModificacion"
        }
    }
}

