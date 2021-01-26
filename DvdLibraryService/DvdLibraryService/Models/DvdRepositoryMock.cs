using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;

namespace DvdLibraryService.Models
{
    public class DvdRepositoryMock : IDvdRepository
    {
        private static List<Dvd> _dvds;

        static DvdRepositoryMock()
        {
            _dvds = new List<Dvd>()
            {
                new Dvd { Title="Sideways", ReleaseYear=2005, Director="Alexander Payne", Rating="R", Notes="We are not drinking any fucking merlot!", DvdId=1},
                new Dvd { Title="When Harry Met Sally...", ReleaseYear=1989, Director="Rob Reiner", Rating="R", Notes="I'll have what she's having.", DvdId=2}
            };
        }

        public List<Dvd> GetAll()
        {
            return _dvds;
        }

        public Dvd Get(int dvdId)
        {
            return _dvds.FirstOrDefault(d => d.DvdId == dvdId);
        }

        public void Create(Dvd newDvd)
        {
            if (_dvds.Any())
            {
                newDvd.DvdId = _dvds.Max(d => d.DvdId) + 1;
            }
            else
            {
                newDvd.DvdId = 1;
            }

            _dvds.Add(newDvd);
        }

        public void Update(Dvd updatedDvd)
        {
            _dvds.RemoveAll(d => d.DvdId == updatedDvd.DvdId);
            _dvds.Add(updatedDvd);
        }

        public void Delete(int dvdId)
        {
            _dvds.RemoveAll(d => d.DvdId == dvdId);
        }

    }
}