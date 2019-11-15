namespace Serene1.CLIN {
    export enum TipoControles {
        text = 1,
        date = 2,
        dropdown = 3,
        numeric = 4
    }
    Serenity.Decorators.registerEnumType(TipoControles, 'Serene1.CLIN.TipoControles', 'CLIN.TipoControles');
}

