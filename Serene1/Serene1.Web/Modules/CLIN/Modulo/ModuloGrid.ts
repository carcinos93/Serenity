
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class ModuloGrid extends Serenity.EntityGrid<ModuloRow, any> {
        protected getColumnsKey() { return 'CLIN.Modulo'; }
        protected getDialogType() { return ModuloDialog; }
        protected getIdProperty() { return ModuloRow.idProperty; }
        protected getLocalTextPrefix() { return ModuloRow.localTextPrefix; }
        protected getService() { return ModuloService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}