
namespace Serene1.CLIN.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.ProfesionesRow;

    public class ProfesionesRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyOverrideInsertHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyOverrideUpdateHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }

        private class MyOverrideUpdateHandler : SaveRequestHandler<MyRow>
        {
          
           protected override void BeforeSave()
            {
                /* var f = fld.FindField("FECHA_MODIFICACION");
                 if (! Nullable.Equals(f, null) )
                 {
                     f.DefaultValue = DateTime.Now;

                     this.SetDefaultValue(f);
                 }*/

                this.Row.FechaModificacion = DateTime.Now;    
                base.BeforeSave();
            }
        }

        private class MyOverrideInsertHandler : SaveRequestHandler<MyRow>
        {
            protected override void BeforeSave()
            {
                /* var f = fld.FindField("FECHA_CREACION");
                 if (!Nullable.Equals(f, null))
                 {
                     f.DefaultValue = DateTime.Now;

                     this.SetDefaultValue(f);
                 }
                 */
                this.Row.FechaCreacion = DateTime.Now;

                base.BeforeSave();
            }
        }
    }
}