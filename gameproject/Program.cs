// See https://aka.ms/new-console-template for more information
using gameproject;
using gameproject.concrete;
using gameproject.entitiy;

Gamer gamer = new Gamer();
gamer.FirstName = "doğaşen";
gamer.LastName = "pehlivan";
gamer.BirthYear = new DateTime(1999);
gamer.NationalityId = "11111111";

Campaign campaign = new Campaign();
campaign.CampaignName = "büyük fırsat ";
campaign.DiscountRate = 20;
campaign.Id = 1;


Game game = new Game();
game.GameName = "vampir :";
game.GamePrice = 70;
game.Id = 2;

GamerManager manager = new(new GamerCheckManager());
manager.Update(gamer);  

 
GameSaleManager gameSaleManager = new GameSaleManager();
gameSaleManager.Sale(game);


CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(campaign);

CampaignManager campaignManager2 = new CampaignManager();
campaignManager.Delete(campaign);

Console.ReadLine();
