using UnityEngine;

public class CharacterSelectionPanel : BasePanel 
{
    public BasePanel menu;
    public BasePanel gameplay;

    public void Play()
    {
        actions.Add(gameplay.Show);
        this.Hide();
    }

    public void Back()
    {
        actions.Add(menu.Show);
        this.Hide();
    }
}