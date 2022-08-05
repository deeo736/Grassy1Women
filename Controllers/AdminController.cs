
using GrassyWomen.Dto;
using GrassyWomen.Models;
using GrassyWomen.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GrassyWomen.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("/admin/manageCakes")]
    public class AdminController : Controller
    {

        private readonly IOrderServices _orderService;
        private readonly IProductServices _ProductService;

        


    }
}
