
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class EstadosGrid extends Serenity.EntityGrid<EstadosRow, any> {
        protected getColumnsKey() { return 'CLIN.Estados'; }
        protected getDialogType() { return EstadosDialog; }
        protected getIdProperty() { return EstadosRow.idProperty; }
        protected getLocalTextPrefix() { return EstadosRow.localTextPrefix; }
        protected getService() { return EstadosService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}