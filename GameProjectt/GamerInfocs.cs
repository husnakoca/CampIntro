namespace GameProjectt
{
    public class GameInfo
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 7264737;
            gamer1.Name = "Sarp";
            gamer1.Surname = "Palaur";
            gamer1.NationalId = 10269338080;
            gamer1.EMail = "sarppalaur@gmail.com";
            gamer1.DateOfBirth = "9.11.1987";

            Gamer gamer2 = new Gamer();
            gamer2.Id = 7264737;
            gamer2.Name = "Samet";
            gamer2.Surname = "Gonullu";
            gamer2.NationalId = 10269338081;
            gamer2.EMail = "sametgonullu@gmail.com";
            gamer2.DateOfBirth = "30.06.1989";

            Campaign campaign1 = new Campaign();
            campaign1.Id = 3543521;
            campaign1.Name = "Super Weekend!";
            campaign1.Sales = "Monthly gaming membership is only $500 instead of $600!";

            Campaign campaign2 = new Campaign();
            campaign2.Id = 8743687;
            campaign2.Name = "Huge Discount!";
            campaign2.Sales = "50% discount on game character costumes for today!";

        }
    }
}
