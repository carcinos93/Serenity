
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class GruposGrid extends Serenity.EntityGrid<GruposRow, any> {
        protected getColumnsKey() { return 'CLIN.Grupos'; }
        protected getDialogType() { return GruposDialog; }
        protected getIdProperty() { return GruposRow.idProperty; }
        protected getLocalTextPrefix() { return GruposRow.localTextPrefix; }
        protected getService() { return GruposService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}