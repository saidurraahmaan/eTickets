using eTickets.Data.Base;
using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>,ICinemasServices
    {

        public CinemasService(AppDbContext context):base(context)
        {
               
        }
    }
}
