using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdLibraryService.Models
{
    public interface IDvdRepository
    {
        Dvd Get(int dvdId);
        List<Dvd> GetAll();
        void Create(Dvd dvd);
        void Update(Dvd dvd);
        void Delete(int dvdId);
    }
}
