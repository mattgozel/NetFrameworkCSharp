using FlooringMastery.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Data
{
    public class TaxInfoRepository
    {
        public List<Tax> GetTaxInfo()
        {
            List<Tax> taxInfo = new List<Tax>();

            using (StreamReader sr = new StreamReader(@"C:\data\FlooringData\Taxes.txt"))
            {
                sr.ReadLine();
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Tax tax = new Tax();

                    var columns = line.Split(',');

                    tax.StateAbbreviation = columns[0];
                    tax.StateName = columns[1];
                    tax.TaxRate = decimal.Parse(columns[2]);

                    taxInfo.Add(tax);
                }
            }

            return taxInfo;
        }
    }
}
