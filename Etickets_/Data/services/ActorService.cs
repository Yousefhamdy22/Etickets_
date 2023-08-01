using Etickets_.Data.services;
using Etickets_.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etickets_.Data.Base
{
    public class ActorsService : EnitiyBaseRepository<Actor> , IActor
    {
        public ActorsService(Eco_Context context) : base(context) { }
    }

}
