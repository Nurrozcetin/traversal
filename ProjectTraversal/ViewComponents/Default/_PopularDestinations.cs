using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTraversal.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
 