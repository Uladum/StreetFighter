/*
 * V0.04 : Started the implementation of IntroScreen.
 */

using System.Threading;
using System.IO;

class IntroScreen : Screen
{
    protected Image introImage;
    protected Font font;
    protected Font bigFont;
    string[] lines;

    public IntroScreen(Hardware hardware, string fileName) : base(hardware)
    {
        introImage = new Image("imgs/introImg.png", 800, 516);
        font = new Font("font/chargen.ttf", 40);
        bigFont = new Font("font/chargen.ttf", 70);
        lines = File.ReadAllLines(fileName);
    }

    public override void Show()
    {
        // Draws first text of the intro and waits.
        hardware.ClearScreen();
        hardware.WriteText(lines[0], 
            30, 230, 255, 255 ,255, font);
        hardware.UpdateScreen();
        Thread.Sleep(3000);
        
        // Draws the intro image and the title of the game and waits a bit more.
        hardware.ClearScreen();
        hardware.DrawImage(introImage);
        hardware.WriteText("THE DAM FIGHTERS",
            60, 150, 0, 0, 102, bigFont);
        hardware.UpdateScreen();
        Thread.Sleep(3000);
    }
}

