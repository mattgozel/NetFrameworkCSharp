using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DvdLibraryService.Models
{
    public class DvdRepositoryEF : IDvdRepository
    {
        public List<Dvd> _dvds;

        public DvdRepositoryEF()
        {
            _dvds = new List<Dvd>()
            {

            };
        }
        public void Create(Dvd dvd)
        {
            var DBListOfDvds = new DvdEntities();

            DBListOfDvds.Dvd.Add(dvd);
            DBListOfDvds.SaveChanges();
        }

        public void Delete(int dvdId)
        {
            var DBListOfDvds = new DvdEntities();

            var dvd = DBListOfDvds.Dvd.FirstOrDefault(d => d.DvdId == dvdId);

            DBListOfDvds.Dvd.Remove(dvd);
            DBListOfDvds.SaveChanges();
        }

        public Dvd Get(int dvdId)
        {
            var DBListOfDvds = new DvdEntities();

            var selectDvd = DBListOfDvds.Dvd.FirstOrDefault(s => s.DvdId == dvdId);

            return selectDvd;
        }

        public List<Dvd> GetAll()
        {
            var DBListOfDvds = new DvdEntities();

            foreach (var dvd in DBListOfDvds.Dvd)
            {
                _dvds.Add(dvd);
            }

            return _dvds;
        }

        public void Update(Dvd dvd)
        {
            var DBListOfDvds = new DvdEntities();

            DBListOfDvds.Entry(dvd).State = EntityState.Modified;
            DBListOfDvds.SaveChanges();
        }
    }
}