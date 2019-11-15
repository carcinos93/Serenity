
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class AppCamposGrid extends Serenity.EntityGrid<AppCamposRow, any> {
        protected getColumnsKey() { return 'CLIN.AppCampos'; }
        protected getDialogType() { return AppCamposDialog; }
        protected getIdProperty() { return AppCamposRow.idProperty; }
        protected getLocalTextPrefix() { return AppCamposRow.localTextPrefix; }
        protected getService() { return AppCamposService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}