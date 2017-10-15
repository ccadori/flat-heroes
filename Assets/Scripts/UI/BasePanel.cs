using UnityEngine;

public class BasePanel : MonoBehaviour 
{
    public GameObject panel;

    public virtual void Show()
    {
        panel.SetActive(true);
    }

    public virtual void Hide()
    {
        panel.SetActive(false);
    }
}