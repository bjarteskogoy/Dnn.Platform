﻿#region Copyright
// 
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2014
// by DotNetNuke Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

using System;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Definitions;
using DotNetNuke.Entities.Tabs;
using DotNetNuke.Services.Upgrade;

namespace Dnn.Modules.Sql.Components
{
    /// <summary>
    /// 
    /// </summary>
    public class BusinessController : IUpgradeable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public string UpgradeModule(string version)
        {
            try
            {
                switch (version)
                {
                    case "08.00.00":
                        //ModuleDefinitionInfo moduleDefinition = ModuleDefinitionController.GetModuleDefinitionByFriendlyName("SQL");
                        //if (moduleDefinition != null)
                        //{
                        //    //Create New Host Page (or get existing one)
                        //    TabInfo sqlPage = Upgrade.AddHostPage("SQL",
                        //                                "Execute SQL queries against the database..",
                        //                                "~/Icons/Sigma/Sql_32x32_Standard.png",
                        //                                "~/Icons/Sigma/Sql_16x16_Standard.png",
                        //                                true);

                        //    //Add Module To Page
                        //    Upgrade.AddModuleToPage(sqlPage,
                        //                                moduleDefinition.ModuleDefID,
                        //                                "SQL",
                        //                                "~/Icons/Sigma/Sql_32x32_Standard.png",
                        //                                true);
                        //}
                        break;
                }
                return "Success";
            }
            catch (Exception)
            {
                return "Failed";
            }
        }
    }
}
