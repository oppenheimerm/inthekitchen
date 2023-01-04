using ITK.Core;
using ITK.DataStore.EFCore;
using ITK.UseCases.Interfaces;
using ITK.UseCases.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ITK.Web.Pages
{
    public class IndexModel : PageModel
    {
        public int? PageIndex { get; set; }
        public IndexModel()
        {   
        }
        

        public void OnGet(int? pageIndex)
        {
            PageIndex = pageIndex;
        }
    }
}