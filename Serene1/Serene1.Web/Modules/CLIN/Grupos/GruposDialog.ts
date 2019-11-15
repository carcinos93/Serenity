
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class GruposDialog extends Serenity.EntityDialog<GruposRow, any> {
        protected getFormKey() { return GruposForm.formKey; }
        protected getIdProperty() { return GruposRow.idProperty; }
        protected getLocalTextPrefix() { return GruposRow.localTextPrefix; }
        protected getNameProperty() { return GruposRow.nameProperty; }
        protected getService() { return GruposService.baseUrl; }

        protected form = new GruposForm(this.idPrefix);

    }
}