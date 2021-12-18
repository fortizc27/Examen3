using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface ICompraService
    {
        Task<DBEntity> Create(CompraEntity entity);
        Task<DBEntity> Delete(CompraEntity entity);
        Task<IEnumerable<CompraEntity>> Get();
        Task<IEnumerable<CompraEntity>> GetLista();
        Task<CompraEntity> GetById(CompraEntity entity);
        Task<DBEntity> Update(CompraEntity entity);
    }

    public class CompraService : ICompraService
    {
        private readonly IDataAccess sql;

        public CompraService(IDataAccess _sql)
        {
            sql = _sql;
        }


        #region MetodosCRUD

        //Método GET
        public async Task<IEnumerable<CompraEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<CompraEntity, ProductoEntity, ClientesEntity>("dbo.CompraObtener", "IdCompra, IdProducto, IdCliente");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Método GET Lista
        public async Task<IEnumerable<CompraEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<CompraEntity>("dbo.CompraLista");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Método GET ID
        public async Task<CompraEntity> GetById(CompraEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<CompraEntity>("dbo.CompraObtener", new { entity.IdCompra });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }


        //Método CREATE
        public async Task<DBEntity> Create(CompraEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.CompraInsertar", new
                {
                    entity.ClientesId,
                    entity.ProductoId,
                    entity.FechaCompra,
                    entity.Monto,
                    entity.Impuesto,
                    entity.Total,
                    entity.Observaciones,
                    entity.Estado
                });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }


        //Método UPDATE
        public async Task<DBEntity> Update(CompraEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.CompraActualizar", new
                {
                    entity.IdCompra,
                    entity.ClientesId,
                    entity.ProductoId,
                    entity.FechaCompra,
                    entity.Monto,
                    entity.Impuesto,
                    entity.Total,
                    entity.Observaciones,
                    entity.Estado
                });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }


        //Método ELIMINAR
        public async Task<DBEntity> Delete(CompraEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.CompraEliminar", new
                {
                    entity.IdCompra
                });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }


        #endregion

    }
}


