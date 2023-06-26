using eMag.Data.Base;
using eMag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMag.Data.Services
{
    public class CinemasService:EntityBaseRepository<Producator>, IProducatorService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
