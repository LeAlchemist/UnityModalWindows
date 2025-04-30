using TMPro;
using UnityEngine;

public partial class GenericModalWindow : MonoBehaviour
{
    [Header("Header")]
    [SerializeField]
    private Transform _headerArea;
    [SerializeField]
    private TextMeshPro _headerText;

    public void SetHeaderArea()
    {
        _headerArea = GetComponent<Transform>();
    }

    public void SetHeaderText()
    {

    }
}
