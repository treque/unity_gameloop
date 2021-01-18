using UnityEngine;

public class QuitMenuButton : MenuButtonBase
{
    protected override void ExecutePressAction()
    {
        Application.Quit();
    }
}
