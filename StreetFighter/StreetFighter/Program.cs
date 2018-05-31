
class Game
{
    public static string language;

    static void Main(string[] args)
    {
        language = "eng";

        GameController controller = new GameController();
        controller.Start();
    }

    public static void SetLanguage(string lang)
    {
        language = lang;
    }
}
