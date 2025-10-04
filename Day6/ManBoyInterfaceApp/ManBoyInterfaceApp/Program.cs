using ManBoyInterfaceApp.InsiteInternaitonal;

namespace ManBoyInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man  man = new Man();
            Boy boy = new Boy();

            AtTheParty(man);
            AtTheParty(boy);

            AtTheMovies(boy);
          //  AtTheMovies(man);//error
            
        }

        static void AtTheMovies(IEmotionable obj) {

            Console.WriteLine("At the movies");
            obj.Cry();
            obj.Laugh();
        }

        static void AtTheParty(IMannerable obj) {

            Console.WriteLine("Aht the party");
            obj.Wish();
            obj.Depart();
        }
    }
}
