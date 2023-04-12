using GameProject.Concrete;
using GameProject.Entitiy;
using GameProject.NewFolder;


internal class Program
{
    private static void Main(string[] args)
    {
        Player player1 = new Player();
        player1 = new Player { Id = 1, PlayerFirstName = "Yunus Emre", PlayerLastName = "Şeker", DateOfBirth = new DateTime(1999,2,15) , TcNo = 5399423771 };

        Game game1 = new Game();
        game1 = new Game { GameName= "The Forest",GamePrice= 100};

        GameCampaign gameCampaign1 = new GameCampaign();
        gameCampaign1.GameCampaignName = "'Bahar İndirimi'";
        gameCampaign1.GameCampaignPercent = 30;

        IGameSelling gameSellingManager = new GameSellingManager();
        ICampaignService campaignManager1 = new CampaignManager();
        PlayerManager playerManager1 = new PlayerManager();
        ICheckService checkService = new PlayerManager();

        playerManager1.SignUp(player1);
        playerManager1.UpdateAccount(player1);
        playerManager1.DeleteAccount(player1);
        playerManager1.CheckIfRealPlayer(player1);

        Console.WriteLine("---------------------");

        gameSellingManager.GameSelling(player1, game1, gameCampaign1);

        Console.WriteLine("---------------------");

        campaignManager1.NewCampaign(gameCampaign1);
        campaignManager1.UpdateCampaign(gameCampaign1);
        campaignManager1.DeleteCampaign(gameCampaign1);

        Console.ReadLine();

    }
}