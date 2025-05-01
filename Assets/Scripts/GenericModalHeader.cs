using TMPro;
using UnityEngine;

public partial class GenericModalWindow : MonoBehaviour
{
    [Header("Header")]
    [SerializeField]
    private Transform _headerArea;
    [SerializeField]
    private TextMeshProUGUI _headerText;

    public void SetHeaderArea()
    {
        _headerArea = this.gameObject.transform.GetChild(0).GetChild(0);
        _headerText = _headerArea.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    public void SetHeaderText(string headerText)
    {
        _headerText.text = headerText;
    }
}
