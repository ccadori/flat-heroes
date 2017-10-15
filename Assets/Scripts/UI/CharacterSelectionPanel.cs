using UnityEngine;

public class CharacterSelectionPanel : BasePanel 
{
    public BasePanel menu;
    public BasePanel option;

    public void Play()
    {
        this.Hide();
    }

    public void Back()
    {
        menu.Show();
        option.Show();
        this.Hide();
    }
}