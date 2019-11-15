
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class ModuloDialog extends Serenity.EntityDialog<ModuloRow, any> {
        protected getFormKey() { return ModuloForm.formKey; }
        protected getIdProperty() { return ModuloRow.idProperty; }
        protected getLocalTextPrefix() { return ModuloRow.localTextPrefix; }
        protected getNameProperty() { return ModuloRow.nameProperty; }
        protected getService() { return ModuloService.baseUrl; }

        protected form = new ModuloForm(this.idPrefix);

    }
}