namespace Serene1.CLIN {
    export interface TablasRow {
        Esquema?: string;
        Tabla?: string;
    }

    export namespace TablasRow {
        export const idProperty = 'Tabla';
        export const nameProperty = 'Tabla';
        export const localTextPrefix = 'CLIN.Tablas';
        export const lookupKey = 'CLIN.Tablas';

        export function getLookup(): Q.Lookup<TablasRow> {
            return Q.getLookup<TablasRow>('CLIN.Tablas');
        }

        export declare const enum Fields {
            Esquema = "Esquema",
            Tabla = "Tabla"
        }
    }
}

