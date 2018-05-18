/*
 * V0.04 : Started the implementation of MenuScreen.
 */

using Tao.Sdl;

class MenuScreen : Screen
{
    protected Image menuImage;
    protected Font font;
    protected Font bigFont;
    public byte MenuOption { get; set; }
    public bool Exit { get; set; }

    public MenuScreen(Hardware hardware) : base(hardware)
    {
        menuImage = new Image("imgs/background2.png", 932, 600);
        font = new Font("font/chargen.ttf", 40);
        bigFont = new Font("font/chargen.ttf", 70);
        MenuOption = 0;
        Exit = false;
    }

    public override void Show()
    { 
        // Drawing the menu texts
        hardware.ClearScreen();
        hardware.DrawImage(menuImage);
        hardware.WriteText("Story mode",
            60, 280, 0, 0, 102, font);
        hardware.WriteText("2 player mode",
            60, 190, 0, 0, 102, font);
        hardware.WriteText("Tutorial",
            60, 230, 0, 0, 102, font);
        hardware.WriteText("Exit",
            60, 270, 0, 0, 102, font);
        hardware.UpdateScreen();

        Exit = false;

        do
        {
            //if (!hardware.IsKeyPressed(Sdl.SDLK_ESCAPE))
            //{
                if ((hardware.KeyPressed() == Sdl.SDLK_DOWN) && 
                    MenuOption < 4)
                {
                    MenuOption++;
                }
                else if((hardware.KeyPressed() == Sdl.SDLK_UP) && 
                    MenuOption >= 0)
                {
                    MenuOption--;
                }
                System.Console.WriteLine(MenuOption);
            //}
        } while (!hardware.IsKeyPressed(Sdl.SDLK_ESCAPE));
    }
}
