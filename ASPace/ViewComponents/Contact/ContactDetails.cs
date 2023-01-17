using Microsoft.AspNetCore.Mvc;

namespace ASPace.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
