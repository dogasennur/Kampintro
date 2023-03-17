using gameproject.@abstract;
using gameproject.entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameproject.concrete
{
    public class GamerManager : IGamerService

    {
        IGamerService CheckService;
        private GamerCheckManager gamerCheckManager;

        public GamerManager(IGamerService service)
        {
           this.CheckService = service; 
        }

        public GamerManager(GamerCheckManager gamerCheckManager)
        {
            this.gamerCheckManager = gamerCheckManager;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("sisteme hoşgeldiniz:"+ gamer.FirstName);
        }


        public void Delete (Gamer gamer)
        {
            Console.WriteLine("sistemden silindiniz:" +gamer.FirstName);
        }

        

        public void Update(Gamer gamer)
        {
            Console.WriteLine("sistem güncellemesi yapıldı:"+gamer.FirstName);
        }
    }
}
