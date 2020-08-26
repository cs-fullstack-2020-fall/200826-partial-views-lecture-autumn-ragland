using Microsoft.AspNetCore.Mvc;
using ResidentDirectory.ViewModels;
using ResidentDirectory.Models;
using System.Linq;

namespace ResidentDirectory.Controllers
{
    public class Resident : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ResidentList residentList = new ResidentList();
        public IActionResult ViewAll()
        {
            return View(residentList);
        }
        public IActionResult ViewOne(int apartID)
        {
            ResidentModel matchingResident = residentList.residents.FirstOrDefault(res => res.apartmentID == apartID);
            if(matchingResident != null)
            {
                return View(matchingResident);
            } else {
                return Content("Not found");
            }
        }
        public IActionResult ViewWithChildren()
        {
            return View(residentList);
        }
    }
}