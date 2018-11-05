using Penso.Common.Mapper;
using Penso.Domain.ViewModels;
using Penso.Interfaces.Management;
using Penso.Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Penso.Web.Controllers
{
    public class HomeController : Controller
    {
		private IUserManagement userManagement;

		public HomeController(IUserManagement userManagement)
		{
			this.userManagement = userManagement;
		}
        // GET: Home
        public async  Task<ActionResult> Index()
        {
			var domainUsers = await userManagement.ListAll();
			var users = ModelMapper.Map<UserVM>(domainUsers);
            return View(users);
        }
    }
}