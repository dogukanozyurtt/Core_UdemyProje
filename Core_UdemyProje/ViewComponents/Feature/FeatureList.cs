﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_UdemyProje.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {

        FeatureManager featureManager = new FeatureManager(new EfFeatureDal() );


        public IViewComponentResult Invoke()
        {

            var values = featureManager.TGetList();

            return View(values);
        }


    }
}
