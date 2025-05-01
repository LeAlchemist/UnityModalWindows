using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class GenericModalWindow : MonoBehaviour
{
    public Sprite sprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (_headerArea == null)
        {
            SetHeaderArea();
        }
        if (_contentArea == null)
        {
            SetContentArea();
        }
        if (_footerArea == null)
        {
            SetFooterArea();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowAsPopup(string title)
    {
        SetHeaderText(headerText: title);
        _horizontalArea.gameObject.SetActive(true);
        _verticalArea.gameObject.SetActive(false);
    }

    public void ShowAsHero(string title, string message, Sprite imageToShow = null, bool invert = false)
    {
        SetHeaderText(headerText: title);
        SetContentImage(contentImage: imageToShow, isPrompt: false);
        SetContentText(contentText: message, isPrompt: false);
        _verticalArea.GetComponent<VerticalLayoutGroup>().reverseArrangement = invert;
        _horizontalArea.gameObject.SetActive(false);
        _verticalArea.gameObject.SetActive(true);
    }

    public void ShowAsPrompt(string title, string message, Sprite imageToShow = null, bool invert = false)
    {
        SetHeaderText(headerText: title);
        SetContentImage(contentImage: imageToShow, isPrompt: true);
        SetContentText(contentText: message, isPrompt: true);
        _horizontalArea.GetComponent<HorizontalLayoutGroup>().reverseArrangement = invert;
        _horizontalArea.gameObject.SetActive(true);
        _verticalArea.gameObject.SetActive(false);
    }

    public void RefreshContent()
    {

    }
}
