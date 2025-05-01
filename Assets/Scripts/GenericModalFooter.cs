using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public partial class GenericModalWindow : MonoBehaviour
{
    [Header("Footer")]
    [SerializeField]
    private Transform _footerArea;
    [SerializeField]
    private List<Button> _footerButtons = new();
    [SerializeField]
    private List<Action> _buttonActions = new();

    public void SetFooterArea()
    {
        _footerArea = this.gameObject.transform.GetChild(0).GetChild(2);
        GetButtons();
        SetActions();
    }

    //will need to create a new button visually and assign it to the array
    public void AddButtons(string buttonName, Color buttonColor = default(Color), Color textColor = default(Color))
    {
        Color _textColor = new();
        Color _buttonColor = new();
        if (object.Equals(textColor, default(Color))) _textColor = new Color(0, 0, 0, 255);
        else _textColor = textColor;

        if (object.Equals(buttonColor, default(Color))) _buttonColor = new Color(255, 255, 255, 255);
        else _buttonColor = buttonColor;

        var _button = new GameObject(buttonName, typeof(Button));

        var _text = new GameObject("Text", typeof(TextMeshProUGUI));

        _text.transform.SetParent(_button.transform);
        _button.transform.SetParent(_footerArea);

        _button.AddComponent<RectTransform>();
        _button.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
        _button.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        _button.AddComponent<CanvasRenderer>();
        _button.AddComponent<Image>();
        _button.GetComponent<Image>().sprite = Resources.Load("Resources/unity_builtin_extra/UISprite", typeof(Sprite)) as Sprite;
        _button.GetComponent<Image>().color = _buttonColor;
        _button.GetComponent<Button>().image = _button.GetComponent<Image>();

        string r = Convert.ToInt32(_textColor.r).ToString("X2");
        string g = Convert.ToInt32(_textColor.g).ToString("X2");
        string b = Convert.ToInt32(_textColor.b).ToString("X2");
        string a = Convert.ToInt32(_textColor.a).ToString("X2");

        Debug.Log($"{r}{g}{b}{a}");

        string _Color = new($"{r}{g}{b}{a}");
        _text.GetComponent<TextMeshProUGUI>().text = $"<color=#{_Color}> {buttonName}";
        _text.GetComponent<TextMeshProUGUI>().fontSize = 24;
        _text.GetComponent<TextMeshProUGUI>().horizontalAlignment = HorizontalAlignmentOptions.Center;
        _text.GetComponent<TextMeshProUGUI>().verticalAlignment = VerticalAlignmentOptions.Middle;
        _text.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0);
        _text.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
        _text.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
    }

    public void RemoveButtons()
    {

    }

    public void GetButtons()
    {
        for (int i = 0; i < _footerArea.transform.childCount; i++)
        {
            _footerButtons.Add(_footerArea.transform.GetChild(i).GetComponent<Button>());
        }
    }

    public void SetActions()
    {
        for (int i = 0; i < _footerArea.transform.childCount; i++)
        {

        }
    }

    public void DebugAction()
    {
        Debug.Log("Placeholder");
    }
}
