
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class AppFormularioDialog extends Serenity.EntityDialog<AppFormularioRow, any> {
        protected getFormKey() { return AppFormularioForm.formKey; }
        protected getIdProperty() { return AppFormularioRow.idProperty; }
        protected getLocalTextPrefix() { return AppFormularioRow.localTextPrefix; }
        protected getNameProperty() { return AppFormularioRow.nameProperty; }
        protected getService() { return AppFormularioService.baseUrl; }

        protected form = new AppFormularioForm(this.idPrefix);

    }
}