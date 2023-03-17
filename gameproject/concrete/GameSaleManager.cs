using gameproject.@abstract;
using gameproject.entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameproject.concrete
{
    public class GameSaleManager : IGameSalesService
    {
        public void Sale(Gamer gamer, Campaign campaign, Game game)
        {
            float price= (game.GamePrice) -((game.GamePrice* campaign.DiscountRate)/ 100);
            Console.WriteLine("oyun" + gamer.FirstName + "kullanıcısına satıldı");
        }

        public void Sale(Game game)
        {
            Console.WriteLine( game.GameName+ "oyunu satıldı");
        }

        internal void Sale()
        {
            throw new NotImplementedException();
        }
    }
}
