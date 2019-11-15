namespace Serene1.CLIN {
    export namespace PlantillaCorreoService {
        export const baseUrl = 'CLIN/PlantillaCorreo';

        export declare function Create(request: Serenity.SaveRequest<PlantillaCorreoRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<PlantillaCorreoRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PlantillaCorreoRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PlantillaCorreoRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "CLIN/PlantillaCorreo/Create",
            Update = "CLIN/PlantillaCorreo/Update",
            Delete = "CLIN/PlantillaCorreo/Delete",
            Retrieve = "CLIN/PlantillaCorreo/Retrieve",
            List = "CLIN/PlantillaCorreo/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>PlantillaCorreoService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

