using ITK.DataStore.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ITK.Web.Pages.Explore
{
    public class NewModel : PageModel
    {
        public FilterType ParamFilterType { get; set; }

        private readonly ILogger<NewModel> _logger;

        public NewModel(ILogger<NewModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(FilterType? filterType)
        {
            if (filterType == null)
            {
                //  Default
                ParamFilterType = FilterType.All;
            }
            else
            {
                ParamFilterType = filterType.Value;
            }
        }
    }
}
