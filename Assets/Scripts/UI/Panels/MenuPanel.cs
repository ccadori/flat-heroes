using UnityEngine;
    
public class MenuPanel : BasePanel
{   
    public BasePanel characterSelecion;

    public void Play()
    {
        actions.Add(characterSelecion.Show);
        this.Hide();
    }

    public void Exit()
    {
        Application.Quit();
    }
}   