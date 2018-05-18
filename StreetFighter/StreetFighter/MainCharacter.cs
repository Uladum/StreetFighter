class MainCharacter : MovableSprite
{
    public const byte STEP_LENGTH = 2;
    public short Life { get; set; }
    public short Points { get; set; }
    //public List<Ability> Ability = { get; }

    public MainCharacter()
    {
        Points = 0;
    }
}
