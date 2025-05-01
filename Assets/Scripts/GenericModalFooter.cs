using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class GenericModalWindow : MonoBehaviour
{
    [Header("Footer")]
    [SerializeField]
    private Transform _footerArea;
    [SerializeField]
    private Button[] _footerButtons;
    [SerializeField]
    private Action[] _buttonActions;

    public void SetFooterArea()
    {
        _footerArea = this.gameObject.transform.GetChild(0).GetChild(2);
    }

    //will need to create a new button visually and assign it to the array
    public void AddButtons()
    {

    }

    public void RemoveButtons()
    {

    }

    public void GetButtons()
    {

    }

    public void SetActions()
    {

    }
}
