using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using Vox.Core.Pistols;
using Vox.Ultilities.DesignPatterns.Singleton;

public class ButtonClicked : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnButtonClick()
    {
        _textMeshPro.text = $"{_pistol.Initialize()}";

        if (!_isClicked)
        {
            _classicObject.SetActive(true);
            _pistol.Shoot();
            _isClicked = !_isClicked;
        }
        else
        {
            _classicObject.SetActive(false);
            _isClicked = !_isClicked;
        }

    }

    [SerializeField] private GameObject _classicObject;
    [SerializeField] private Pistol _pistol;
    [SerializeField] private TextMeshProUGUI _textMeshPro;

    private bool _isClicked = false;
}
