
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class EstadosDialog extends Serenity.EntityDialog<EstadosRow, any> {
        protected getFormKey() { return EstadosForm.formKey; }
        protected getIdProperty() { return EstadosRow.idProperty; }
        protected getLocalTextPrefix() { return EstadosRow.localTextPrefix; }
        protected getNameProperty() { return EstadosRow.nameProperty; }
        protected getService() { return EstadosService.baseUrl; }

        protected form = new EstadosForm(this.idPrefix);

    }
}