using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class GenericModalWindow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetHeaderArea();
        SetContentArea();
        SetFooterArea();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateModal()
    {

    }

    public void ShowAsHero(string title, string message, Sprite imageToShow, bool invert)
    {
        SetContentImage(isPrompt: false);
        SetContentText(isPrompt: false);
    }

    public void ShowAsPrompt(string title, string message, Sprite imageToShow, bool invert)
    {
        SetContentImage(isPrompt: true);
        SetContentText(isPrompt: true);
    }

    public void RefreshContent()
    {

    }
}
