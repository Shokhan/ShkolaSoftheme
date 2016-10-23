using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Concrete
{
    public class EFSpareRepository : ISpareRepository
    {
        EFDBContext conext = new EFDBContext();
        public IEnumerable<Spare> Spares
        {
            get
            {
                return conext.Spares;
            }
        }
    }
}
