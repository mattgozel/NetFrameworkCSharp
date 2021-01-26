using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DvdLibraryService.Models
{
    public static class DvdManagerFactory
    {
        public static DvdManager Create()
        {
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();

            switch(mode)
            {
                case "SampleData":
                    return new DvdManager(new DvdRepositoryMock());
                case "ADO":
                    return new DvdManager(new DvdRepositoryADO());
                case "EntityFramework":
                    return new DvdManager(new DvdRepositoryEF());
                default:
                    throw new Exception("Mode value in web config is not valid.");
            }
        }
    }
}