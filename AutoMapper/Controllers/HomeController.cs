using AutoMapper.Models;
using AutoMapper.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AutoMapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        public HomeController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            // Populate the user details from DB
            var user = GetUserDetails();
            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);
            return View(userViewModel);
        }

        private object GetUserDetails()
        {
            return new User() {
                
            FirstName="Hasan",
            LastName="Rzayev",
            Email="hsnrz2002@gmail.com"
            };

        }
    }
}