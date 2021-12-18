using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp
{
    public class ServiceApi
    {
        private readonly HttpClient client;

        public ServiceApi(HttpClient client)
        {
            this.client = client;
        }


        /******************************************************************************************************
        PRODUCTO
       ******************************************************************************************************/

        public async Task<IEnumerable<ProductoEntity>> ProductoGet()
        {

            var result = await client.ServicioGetAsync<IEnumerable<ProductoEntity>>("api/Producto");
            return result;

        }

        public async Task<ProductoEntity> ProductoGetById(int id)
        {
            var result = await client.ServicioGetAsync<ProductoEntity>("api/Producto/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;
        }

        public async Task<IEnumerable<ProductoEntity>> ProductoGetLista()
        {

            var result = await client.ServicioGetAsync<IEnumerable<ProductoEntity>>("api/Producto/Lista");
            return result;

        }


        /******************************************************************************************************
        CLIENTE
        ******************************************************************************************************/
        public async Task<IEnumerable<ClientesEntity>> ClienteGet()
        {

            var result = await client.ServicioGetAsync<IEnumerable<ClientesEntity>>("api/Cliente");
            return result;

        }

        public async Task<ClientesEntity> ClienteGetById(int id)
        {
            var result = await client.ServicioGetAsync<ClientesEntity>("api/Cliente/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;
        }


        public async Task<IEnumerable<ClientesEntity>>ClienteGetLista()
        {

            var result = await client.ServicioGetAsync<IEnumerable<ClientesEntity>>("api/Cliente/Lista");
            return result;

        }

        /******************************************************************************************************
        COMPRA
        ******************************************************************************************************/
        public async Task<IEnumerable<CompraEntity>> CompraGet()
        {

            var result = await client.ServicioGetAsync<IEnumerable<CompraEntity>>("api/Compra");
            return result;

        }

        public async Task<CompraEntity> CompraGetById(int id)
        {
            var result = await client.ServicioGetAsync<CompraEntity>("api/Compra/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;
        }
    }
}