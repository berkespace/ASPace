using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ASPace.ViewComponents.Feature
 
{
    public class FeatureView : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var value = featureManager.TGetList();
            return View(value);
        }
    }
}
