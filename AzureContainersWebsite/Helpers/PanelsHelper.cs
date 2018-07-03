using AzureContainersWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureContainersWebsite.Helpers
{
    public static class PanelsHelper
    {
        public static string GetGeneralPanelName(Services service)
            => $"pnl{service.ToString()}General";

        public static string GetHostingPanelName(Services service)
            => $"pnl{service.ToString()}Hosting";

        public static string GetDevOpsPanelName(Services service)
            => $"pnl{service.ToString()}DevOps";

        public static string GetScalabilityPanelName(Services service)
            => $"pnl{service.ToString()}Scalability";

        public static string GetAvailabilityPanelName(Services service)
            => $"pnl{service.ToString()}Availability";

        public static string GetSecurityPanelName(Services service)
            => $"pnl{service.ToString()}Security";

        public static string GetDiscoveryPanelName(Services service)
            => $"pnl{service.ToString()}Discovery";

        public static string GetIntegrationPanelName(Services service)
            => $"pnl{service.ToString()}Integration";

        public static string GetCostSupportPanelName(Services service)
            => $"pnl{service.ToString()}CostSupport";
    }
}
