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
    public static class PurchaseTypeRepositoryFactory
    {
        public static IPurchaseTypeRepository GetRepository()
        {
            switch (Settings.GetMode())
            {
                case "PROD":
                    return new PurchaseTypeRepositoryADO();
                case "QA":
                    return new PurchaseTypeRepositoryQA();
                default:
                    throw new Exception("Could not find valid Mode configuration value.");
            }
        }
    }
}
