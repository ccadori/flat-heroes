using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class CharacterButton : MonoBehaviour
{
    public Image image;
    public Sprite avatar;

    private Toggle toggle;

    private void Awake()
    {
        toggle = GetComponent<Toggle>();
    }

    public void OnValueChange()
    {
        if (toggle.isOn)
        {
            image.sprite = avatar;
        }
    }
}