using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;
using Entity;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        //Grants us access to the service
        // private readonly IClienteService clienteService;

        // public ClienteController(IClienteService clienteService)
        // {
        //     this.clienteService = clienteService;
        // }

        // [HttpGet]
        // public async Task<IEnumerable<ClientesEntity>> Get()
        // {
        //     try
        //     {
        //         return await clienteService.Get();
        //     }
        //     catch (Exception ex)
        //     {
        //         //Returns an empty list of customers
        //         return new List<ClientesEntity>();
        //     }
        // }

        //[HttpGet("{id}")]
        // public async Task<ClientesEntity> GetById(int id)
        // {
        //     try
        //     {
        //         return await clienteService.GetById(new ClientesEntity { ClientesId = id });
        //     }
        //     catch (Exception ex)
        //     {
        //         return new ClientesEntity { CodeError = ex.HResult, MsgError = ex.Message };
        //     }
        // }

        // [HttpPost]
        // public async Task<DBEntity> Create(ClientesEntity entity)
        // {
        //     try
        //     {
        //         return await clienteService.Create(entity);
        //     }
        //     catch (Exception ex)
        //     {
        //         return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
        //     }
        // }

        // [HttpPut]
        // public async Task<DBEntity> Update(ClientesEntity entity)
        // {
        //     try
        //     {
        //         return await clienteService.Update(entity);
        //     }
        //     catch (Exception ex)
        //     {
        //         return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
        //     }
        // }

        // [HttpDelete("{id}")]
        // public async Task<DBEntity> Delete(int id)
        // {
        //     try
        //     {
        //         return await clienteService.Delete(new ClientesEntity() { ClientesId = id });
        //     }
        //     catch (Exception ex)
        //     {
        //         return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
        //     }
        // }

        //[HttpGet("Lista")]
        //public async Task<IEnumerable<ClientesEntity>> GetLista()
        //{
        //    try
        //    {
        //        return await clienteService.GetLista();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Returns an empty list 
        //        return new List<ClientesEntity>();
        //    }
        //}
    }
}
