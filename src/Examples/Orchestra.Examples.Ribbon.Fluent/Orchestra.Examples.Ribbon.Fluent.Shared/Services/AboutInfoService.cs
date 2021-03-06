﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AboutInfoService.cs" company="WildGums">
//   Copyright (c) 2008 - 2015 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orchestra.Examples.Ribbon.Services
{
    using System;
    using Models;
    using Orchestra.Services;

    internal class AboutInfoService : IAboutInfoService
    {
        public AboutInfo GetAboutInfo()
        {
            var aboutInfo = new AboutInfo(new Uri("pack://application:,,,/Resources/Images/CompanyLogo.png", UriKind.RelativeOrAbsolute),
                uriInfo: new UriInfo("http://www.catelproject.com", "Product website"));

            return aboutInfo;
        }
    }
}