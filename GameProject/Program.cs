using GameProject;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player1 = new Player();
        player1 = new Player { Id = 1, PlayerFirstName = "Yunus Emre", PlayerLastName = "Şeker", BirthDate = 15021999, TcNo = "12345678910" };

        Game game1 = new Game();
        game1 = new Game { GameName= "The Forest",GamePrice= 100};

        GameCampaign gameCampaign1 = new GameCampaign();
        gameCampaign1.GameCampaignName = "'Bahar İndirimi'";
        gameCampaign1.GameCampaignPercent = 30;

        GameSellingManager gameSellingManager = new GameSellingManager();
        CampaignManager campaignManager1 = new CampaignManager();
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