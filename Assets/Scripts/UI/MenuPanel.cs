using UnityEngine;
    
public class MenuPanel : BasePanel
{   
    public BasePanel option;
    public BasePanel characterSelecion;

    public void Play()
    {
        characterSelecion.Show();
        option.Hide();
        this.Hide();
    }

    public void Exit()
    {
        Application.Quit();
    }
}   