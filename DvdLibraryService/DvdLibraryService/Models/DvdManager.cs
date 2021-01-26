using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DvdLibraryService.Models
{
    public class DvdManager
    {
        private IDvdRepository _dvdRepository;
        List<Dvd> dvds = new List<Dvd>();
        Dvd dvd = new Dvd();

        public DvdManager(IDvdRepository dvdRepository)
        {
            _dvdRepository = dvdRepository;
        }

        public List<Dvd> GetAll()
        {
            dvds = _dvdRepository.GetAll();
            return dvds;
        }

        public Dvd Get(int dvdId)
        {
            dvd = _dvdRepository.Get(dvdId);
            return dvd;
        }

        public void Create(Dvd dvd)
        {
            dvds = _dvdRepository.GetAll();

            if (dvds.Any())
            {
                dvd.DvdId = dvds.Max(d => d.DvdId) + 1;
            }

            else
            {
                dvd.DvdId = 1;
            }

            dvds.Add(dvd);
            _dvdRepository.Create(dvd);
        }

        public void Update(Dvd dvd)
        {
            dvds = _dvdRepository.GetAll();

            dvds.RemoveAll(d => d.DvdId == dvd.DvdId);
            dvds.Add(dvd);
            _dvdRepository.Update(dvd);
        }

        public void Delete(int dvdId)
        {
            dvds = _dvdRepository.GetAll();

            dvds.RemoveAll(d => d.DvdId == dvdId);

            _dvdRepository.Delete(dvdId);
        }
    }
}