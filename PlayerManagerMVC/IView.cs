namespace PlayerManagerMVC
{
    public interface IView
    {
        string MainMenu();
        void ShowByeMessage();
        void ShowUnknownOptMessage();
        void ShowPressKeyMessage();
        Player AskPlayerInfo();
    }
}