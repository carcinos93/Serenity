
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class AppFormularioGrid extends Serenity.EntityGrid<AppFormularioRow, any> {
        protected getColumnsKey() { return 'CLIN.AppFormulario'; }
        protected getDialogType() { return AppFormularioDialog; }
        protected getIdProperty() { return AppFormularioRow.idProperty; }
        protected getLocalTextPrefix() { return AppFormularioRow.localTextPrefix; }
        protected getService() { return AppFormularioService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}