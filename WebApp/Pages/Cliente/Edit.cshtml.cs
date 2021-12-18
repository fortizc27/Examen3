using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Cliente
{
    public class EditModel : PageModel
    {

        private readonly ServiceApi service;

        public EditModel(ServiceApi service)
        {
            this.service = service;
        }

        [BindProperty]
        public ClientesEntity Entity { get; set; } = new ClientesEntity();
        //public IEnumerable<ClientesEntity> ClientesLista { get; set; } = new List<ClientesEntity>();
       

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await service.ClienteGetById(id.Value);
                }

                //ClientesLista = await service.ClienteGetLista();
               

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }



        }
    }
}
