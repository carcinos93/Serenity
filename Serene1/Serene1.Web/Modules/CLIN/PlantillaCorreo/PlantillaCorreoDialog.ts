
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class PlantillaCorreoDialog extends Serenity.EntityDialog<PlantillaCorreoRow, any> {
        protected getFormKey() { return PlantillaCorreoForm.formKey; }
        protected getIdProperty() { return PlantillaCorreoRow.idProperty; }
        protected getLocalTextPrefix() { return PlantillaCorreoRow.localTextPrefix; }
        protected getNameProperty() { return PlantillaCorreoRow.nameProperty; }
        protected getService() { return PlantillaCorreoService.baseUrl; }

        protected form = new PlantillaCorreoForm(this.idPrefix);
        protected afterLoadEntity() {
           /* super.afterLoadEntity();
            var modulo = this.form.Modulo.value;
            var lookup = Q.getLookup<Serene1.CLIN.TablasRow>("DBO.Tablas").items.filter((v, i , a) => {
                return v.Esquema == modulo;
                
            });

            var value = this.form.Tabla.get_value();
            this.form.Tabla.*/
            
        }
    }
}