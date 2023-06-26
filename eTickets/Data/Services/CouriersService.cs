using eFarm.Data.Base;
using eFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFarm.Data.Services
{
    public class CouriersService: EntityBaseRepository<Courier>, ICouriersService
    {
        public CouriersService(AppDbContext context) : base(context)
        {
        }
    }
}
