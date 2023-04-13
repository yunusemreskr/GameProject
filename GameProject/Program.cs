using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entitiy;
using GameProject.NewFolder;


internal class Program
{
    private static void Main(string[] args)
    {
        IGameSelling gameSellingManager = new GameSellingManager();
        ICampaignService campaignManager1 = new CampaignManager();
        PlayerManager playerManager1 = new PlayerManager(new MernisServiceAdapter());
        ICheckService checkService1 = new MernisServiceAdapter();

        Player player1 = new Player();
        player1.Id= 1;
        player1.PlayerFirstName = "Yunus Emre";
        player1.PlayerLastName = "Şeker";
        player1.TcNo = 10987654321;
        player1.DateOfBirth = new DateTime(1999, 2, 15);

        playerManager1.SignUp(player1);
        
        playerManager1.SignUp(new Player { TcNo = 12345678910, PlayerFirstName = "İrem", PlayerLastName = "Çoban", DateOfBirth = new DateTime(1999, 11, 5) });


        Game game1 = new Game();
        game1 = new Game { GameName = "The Forest", GamePrice = 100 };

        GameCampaign gameCampaign1 = new GameCampaign();
        gameCampaign1.GameCampaignName = "'Bahar İndirimi'";
        gameCampaign1.GameCampaignPercent = 30;

        playerManager1.UpdateAccount(player1);
        playerManager1.DeleteAccount(player1);


        Console.WriteLine("---------------------");

        gameSellingManager.GameSelling(player1, game1, gameCampaign1);

        Console.WriteLine("---------------------");

        campaignManager1.NewCampaign(gameCampaign1);
        campaignManager1.UpdateCampaign(gameCampaign1);
        campaignManager1.DeleteCampaign(gameCampaign1);

        checkService1.CheckIfRealPlayer(player1);

        Console.ReadLine();

        //PlayerManager playerManager1 = new PlayerManager(new MernisServiceAdapter());
        

        Console.ReadLine();

    }
}