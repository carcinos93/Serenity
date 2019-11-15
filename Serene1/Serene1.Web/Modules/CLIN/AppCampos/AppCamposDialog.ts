
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class AppCamposDialog extends Serenity.EntityDialog<AppCamposRow, any> {
        protected getFormKey() { return AppCamposForm.formKey; }
        protected getIdProperty() { return AppCamposRow.idProperty; }
        protected getLocalTextPrefix() { return AppCamposRow.localTextPrefix; }
        protected getNameProperty() { return AppCamposRow.nameProperty; }
        protected getService() { return AppCamposService.baseUrl; }

        protected form = new AppCamposForm(this.idPrefix);

    }
}