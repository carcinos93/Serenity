
namespace Serene1.CLIN {

    @Serenity.Decorators.registerClass()
    export class PlantillaCorreoGrid extends Serenity.EntityGrid<PlantillaCorreoRow, any> {
        protected getColumnsKey() { return 'CLIN.PlantillaCorreo'; }
        protected getDialogType() { return PlantillaCorreoDialog; }
        protected getIdProperty() { return PlantillaCorreoRow.idProperty; }
        protected getLocalTextPrefix() { return PlantillaCorreoRow.localTextPrefix; }
        protected getService() { return PlantillaCorreoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }


       
    }
}