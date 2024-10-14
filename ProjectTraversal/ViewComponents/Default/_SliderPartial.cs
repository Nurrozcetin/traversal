using Microsoft.AspNetCore.Mvc;

namespace ProjectTraversal.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
