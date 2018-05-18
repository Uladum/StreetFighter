
/**
    * This class will manage the screen flow during the game
    */
class GameController
{
    public const short SCREEN_WIDTH = 800;
    public const short SCREEN_HEIGHT = 500;

    public void Start()
    {
        Hardware hardware = new Hardware(800, 600, 24, false);
        PlayerSelectScreen selectScreen = new PlayerSelectScreen(hardware);
        GameScreen game = new GameScreen(hardware);

        do
        {
            hardware.ClearScreen();
            selectScreen.Show();
            game.Show();
        } while (!hardware.IsKeyPressed(Hardware.KEY_ESC));
    }
}