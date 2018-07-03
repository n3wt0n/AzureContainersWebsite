using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AzureContainersWebsite.Models;
using AzureContainersWebsite.Helpers;

namespace AzureContainersWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetGeneralName(Services service)
            => Json(PanelsHelper.GetGeneralPanelName(service));

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetGeneral(Services service)
            => PartialView($"~/Views/{service.ToString()}/General.cshtml");

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetHostingName(Services service)
            => Json(PanelsHelper.GetHostingPanelName(service));

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetHosting(Services service)
            => PartialView($"~/Views/{service.ToString()}/Hosting.cshtml");

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetDevOpsName(Services service)
            => Json(PanelsHelper.GetDevOpsPanelName(service));

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetDevOps(Services service)
            => PartialView($"~/Views/{service.ToString()}/DevOps.cshtml");

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetScalabilityName(Services service)
            => Json(PanelsHelper.GetScalabilityPanelName(service));

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetScalability(Services service)
            => PartialView($"~/Views/{service.ToString()}/Scalability.cshtml");

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetAvailabilityName(Services service)
            => Json(PanelsHelper.GetAvailabilityPanelName(service));

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetAvailability(Services service)
            => PartialView($"~/Views/{service.ToString()}/Availability.cshtml");

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetSecurityName(Services service)
            => Json(PanelsHelper.GetSecurityPanelName(service));

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetSecurity(Services service)
            => PartialView($"~/Views/{service.ToString()}/Security.cshtml");

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetDiscoveryName(Services service)
            => Json(PanelsHelper.GetDiscoveryPanelName(service));

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetDiscovery(Services service)
            => PartialView($"~/Views/{service.ToString()}/Discovery.cshtml");

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetIntegrationName(Services service)
            => Json(PanelsHelper.GetIntegrationPanelName(service));

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetIntegration(Services service)
            => PartialView($"~/Views/{service.ToString()}/Integration.cshtml");

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetCostSupportName(Services service)
            => Json(PanelsHelper.GetCostSupportPanelName(service));

        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult GetCostSupport(Services service)
            => PartialView($"~/Views/{service.ToString()}/CostSupport.cshtml");
    }
}
