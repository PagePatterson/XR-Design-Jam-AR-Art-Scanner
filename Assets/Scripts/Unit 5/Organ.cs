using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Organ : MonoBehaviour
{
    [SerializeField]
    private Image _organImage;

    [SerializeField]
    private GameObject _Character;

    private bool _rabbit = false;

    public void FoundImage()
    {
        _organImage.color = Color.white;
        if(_rabbit == false)
        {
            Instantiate(_Character);
            _rabbit = true;
        }
    }
}
