using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class GenericModalWindow : MonoBehaviour
{
    [Header("Content")]
    [SerializeField]
    private Transform _contentArea;
    [SerializeField]
    private Transform _horizontalArea;
    [SerializeField]
    private Image _horizontalImage;
    [SerializeField]
    private TextMeshProUGUI _horizontalText;
    [SerializeField]
    private Transform _verticalArea;
    [SerializeField]
    private Image _verticalImage;
    [SerializeField]
    private TextMeshProUGUI _verticalText;

    public void SetContentArea()
    {
        _contentArea = this.gameObject.transform.GetChild(0).GetChild(1);
        //horizontal area
        _horizontalArea = _contentArea.transform.GetChild(0);
        _horizontalImage = _horizontalArea.transform.GetChild(0).GetComponent<Image>();
        _horizontalText = _horizontalArea.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        //vertical area
        _verticalArea = _contentArea.transform.GetChild(1);
        _verticalImage = _verticalArea.transform.GetChild(0).GetComponent<Image>();
        _verticalText = _verticalArea.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
    }

    public void SetContentImage(Sprite contentImage, bool isPrompt)
    {
        switch (contentImage)
        {
            case null:
                _horizontalImage.gameObject.SetActive(false);
                _verticalImage.gameObject.SetActive(false);
                break;
            case not null:
                switch (isPrompt)
                {
                    case true:
                        _horizontalImage.sprite = contentImage;
                        _verticalImage.sprite = null;
                        _horizontalImage.gameObject.SetActive(true);
                        break;
                    case false:
                        _verticalImage.sprite = contentImage;
                        _horizontalImage.sprite = null;
                        _verticalImage.gameObject.SetActive(true);
                        break;
                }
                break;
        }

    }

    public void SetContentText(string contentText, bool isPrompt)
    {
        switch (isPrompt)
        {
            case true:
                _horizontalText.text = contentText;
                _verticalText.text = null;
                break;
            case false:
                _verticalText.text = contentText;
                _horizontalText.text = null;
                break;
        }
    }
}
