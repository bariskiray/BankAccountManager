using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutHeaderPartial: ViewComponent
    {
      public IViewComponentResult Invoke()
        {
            return View();
        }  
    }
}
