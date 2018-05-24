﻿/*
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

    public void Start()
    {
        Hardware hardware = new Hardware(800, 600, 24, false);
        IntroScreen intro = new IntroScreen(hardware);
        MenuScreen menu = new MenuScreen(hardware);
        PlayerSelectScreen selectScreen = new PlayerSelectScreen(hardware);
        GameScreen game = new GameScreen(hardware);

        intro.Show();
        int key;
        do
        {
            key = hardware.KeyPressed();
            menu.Show();
            if (menu.MenuOption == 0 && key == Sdl.SDLK_SPACE)
            {
                game.Show();
            }
            else if (menu.MenuOption == 1 && key == Sdl.SDLK_SPACE)
            {
                selectScreen.Show();
            }
            else if (menu.MenuOption == 2 && key == Sdl.SDLK_SPACE)
            {
                selectScreen.Show();
            }
            else if (menu.MenuOption == 3 && key == Sdl.SDLK_SPACE)
            {
                menu.Exit = true;
            }
        } while (!menu.Exit || !hardware.IsKeyPressed(Sdl.SDLK_ESCAPE));
    }
}