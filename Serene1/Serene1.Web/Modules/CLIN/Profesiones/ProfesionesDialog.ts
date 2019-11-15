
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class ProfesionesDialog extends Serenity.EntityDialog<ProfesionesRow, any> {
        protected getFormKey() { return ProfesionesForm.formKey; }
        protected getIdProperty() { return ProfesionesRow.idProperty; }
        protected getLocalTextPrefix() { return ProfesionesRow.localTextPrefix; }
        protected getNameProperty() { return ProfesionesRow.nameProperty; }
        protected getService() { return ProfesionesService.baseUrl; }

        protected form = new ProfesionesForm(this.idPrefix);

    }
}