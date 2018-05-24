/*
 * V0.04 : Started the implementation of MenuScreen.
 */

using Tao.Sdl;

class MenuScreen : Screen
{
    protected Image menuImage, imgSelectOption;
    protected Font font;
    protected Font bigFont;
    public byte MenuOption { get; set; }
    public bool Exit { get; set; }

    public MenuScreen(Hardware hardware) : base(hardware)
    {
        menuImage = new Image("imgs/background2.png", 932, 600);
        imgSelectOption = new Image("imgs/choose_player.png", 48, 48);
        imgSelectOption.MoveTo(400, 200);
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
        hardware.DrawImage(imgSelectOption);
        hardware.WriteText("Story mode",
            60, 200, 0, 0, 102, font);
        hardware.WriteText("2 player mode",
            60, 240, 0, 0, 102, font);
        hardware.WriteText("Tutorial",
            60, 280, 0, 0, 102, font);
        hardware.WriteText("Exit",
            60, 320, 0, 0, 102, font);
        hardware.UpdateScreen();

        Exit = false;

        int key;
        do
        {
            key = hardware.KeyPressed();
            if (key == Sdl.SDLK_DOWN &&
                MenuOption < 3)
            {
                MenuOption++;
                imgSelectOption.MoveTo(400, (short)(imgSelectOption.Y + 40));
            }
            else if (key == Sdl.SDLK_UP &&
                MenuOption > 0)
            {
                MenuOption--;
                imgSelectOption.MoveTo(400, (short)(imgSelectOption.Y - 40));
            }
            else if (key == Sdl.SDLK_ESCAPE)
            {
                Exit = true;
            }
        }
        while (!Exit && key == Sdl.SDLK_SPACE);
    }
}