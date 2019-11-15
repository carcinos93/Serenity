namespace Serene1.CLIN {
    export interface GruposRow {
        CodigoGrupo?: string;
        NombreGrupo?: string;
        Activo?: string;
        FechaCreacion?: string;
        FechaModificacion?: string;
        CreadoPor?: string;
        ModificadoPor?: string;
        ActivoNombreDecision?: string;
        ActivoFechaCreacion?: string;
        ActivoFechaModificacion?: string;
        ActivoCreadoPor?: string;
        ActivoModificadoPor?: string;
        ActivoIpCliente?: string;
        ActivoAplicacionOrigen?: string;
        ActivoHostCliente?: string;
        Activo1?: number;
        ActivoVisible?: boolean;
        ActivoPermitido?: boolean;
    }

    export namespace GruposRow {
        export const idProperty = 'CodigoGrupo';
        export const nameProperty = 'CodigoGrupo';
        export const localTextPrefix = 'CLIN.Grupos';

        export declare const enum Fields {
            CodigoGrupo = "CodigoGrupo",
            NombreGrupo = "NombreGrupo",
            Activo = "Activo",
            FechaCreacion = "FechaCreacion",
            FechaModificacion = "FechaModificacion",
            CreadoPor = "CreadoPor",
            ModificadoPor = "ModificadoPor",
            ActivoNombreDecision = "ActivoNombreDecision",
            ActivoFechaCreacion = "ActivoFechaCreacion",
            ActivoFechaModificacion = "ActivoFechaModificacion",
            ActivoCreadoPor = "ActivoCreadoPor",
            ActivoModificadoPor = "ActivoModificadoPor",
            ActivoIpCliente = "ActivoIpCliente",
            ActivoAplicacionOrigen = "ActivoAplicacionOrigen",
            ActivoHostCliente = "ActivoHostCliente",
            Activo1 = "Activo1",
            ActivoVisible = "ActivoVisible",
            ActivoPermitido = "ActivoPermitido"
        }
    }
}

