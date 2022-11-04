using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoProject1.Models
{
    public class NavigationViewModel
    {
        public string HomeUrl { get; set; }
        public IEnumerable<NavigationItem> NavigationItems { get; set; }
    }
}
