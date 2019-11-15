namespace Serene1.CLIN {
    export interface ModuloRow {
        CodigoModulo?: string;
        NombreModulo?: string;
        Protocolo?: string;
        SeparadorPuerto?: string;
        Puerto?: string;
        Servidor?: string;
    }

    export namespace ModuloRow {
        export const idProperty = 'CodigoModulo';
        export const nameProperty = 'CodigoModulo';
        export const localTextPrefix = 'CLIN.Modulo';
        export const lookupKey = 'CLIN.Modulo';

        export function getLookup(): Q.Lookup<ModuloRow> {
            return Q.getLookup<ModuloRow>('CLIN.Modulo');
        }

        export declare const enum Fields {
            CodigoModulo = "CodigoModulo",
            NombreModulo = "NombreModulo",
            Protocolo = "Protocolo",
            SeparadorPuerto = "SeparadorPuerto",
            Puerto = "Puerto",
            Servidor = "Servidor"
        }
    }
}

