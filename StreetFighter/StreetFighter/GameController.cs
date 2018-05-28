/*
 * V0.04 : Added some changes to add the intro and menu screens.
 */

/**
    * This class will manage the screen flow during the game
    */

using Tao.Sdl;

class GameController
{
    public const short SCREEN_WIDTH = 800;
    public const short SCREEN_HEIGHT = 500;
    bool exit = false;

    public void Start()
    {
        Hardware hardware = new Hardware(800, 600, 24, false);
        IntroScreen intro = new IntroScreen(hardware,"sentece.txt");
        MenuScreen menu = new MenuScreen(hardware);
        PlayerSelectScreen selectScreen = new PlayerSelectScreen(hardware);
        GameScreen game = new GameScreen(hardware);

        intro.Show();
        menu.Show();

        do
        {
            switch (menu.MenuOption)
            {
                case 0:
                    game.Show();
                    break;
                case 1:
                    selectScreen.Show();
                    break;
                case 2:
                    game.Show();
                    break;
                case 3:
                    exit = true;
                    break;
            }
        } while (!exit);
    }
}