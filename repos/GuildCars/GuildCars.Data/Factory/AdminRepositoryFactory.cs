﻿using GuildCars.Data.ADO;
using GuildCars.Data.Interfaces;
using GuildCars.Data.QA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildCars.Data.Factory
{
    public class AdminRepositoryFactory
    {
        public static IAdminRepository GetRepository()
        {
            switch (Settings.GetMode())
            {
                case "PROD":
                    return new AdminRepositoryADO();
                case "QA":
                    return new AdminRepositoryQA();
                default:
                    throw new Exception("Could not find valid Mode configuration value.");
            }
        }
    }
}
