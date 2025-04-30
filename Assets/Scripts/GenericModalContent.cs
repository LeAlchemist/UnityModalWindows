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
    private TextMeshPro _horizontalText;
    [SerializeField]
    private Transform _verticalArea;
    [SerializeField]
    private Image _verticalImage;
    [SerializeField]
    private TextMeshPro _verticalText;

    public void SetContentArea()
    {
        _contentArea = GetComponent<Transform>();
    }

    public void SetContentImage(bool isPrompt)
    {

    }

    public void SetContentText(bool isPrompt)
    {

    }
}
