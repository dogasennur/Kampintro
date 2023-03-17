using gameproject.@abstract;
using gameproject.entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameproject.concrete
{
    public class GamerCheckManager : ICheckService
    {
       

        bool ICheckService.CheckIfRealGamer(Gamer Gamer)
        {
            return true;
        }
    }
}
