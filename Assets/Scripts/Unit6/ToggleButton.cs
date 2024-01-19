using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : MonoBehaviour
{
    [SerializeField]
    private RectTransform _menuTransform;

    [SerializeField]
    private float _openPosition;

    [SerializeField]
    private float _closePosition;

    private bool _isOpen;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Toggle()
    {
        _isOpen = !_isOpen;

        Vector2 targetPosition = new Vector2(215.1f, _isOpen ? _openPosition : _closePosition); //? means is true then do this : means is false then do this
        _menuTransform.DOAnchorPos(targetPosition, 0.5f);
    }
}
