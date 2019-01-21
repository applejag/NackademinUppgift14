﻿using System;
using System.Web.Mvc;
using System.Web.Optimization;
using UnderConstruction.WebPage.Business.Initialization;

namespace UnderConstruction.WebPage
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }
    }
}