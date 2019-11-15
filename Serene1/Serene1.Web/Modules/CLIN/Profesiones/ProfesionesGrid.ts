
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class ProfesionesGrid extends Serenity.EntityGrid<ProfesionesRow, any> {
        protected getColumnsKey() { return 'CLIN.Profesiones'; }
        protected getDialogType() { return ProfesionesDialog; }
        protected getIdProperty() { return ProfesionesRow.idProperty; }
        protected getLocalTextPrefix() { return ProfesionesRow.localTextPrefix; }
        protected getService() { return ProfesionesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}