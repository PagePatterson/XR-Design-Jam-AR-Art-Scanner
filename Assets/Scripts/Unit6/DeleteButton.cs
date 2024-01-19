using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class DeleteButton : MonoBehaviour
{
    [SerializeField]
    private Button _deleteButton;

    private GameObject _currentSectedGameObject;

    // Start is called before the first frame update
    void Start()
    {
        _deleteButton.onClick.AddListener(DeleteButtonClicked);
    }

    private void DeleteButtonClicked()
    {
        Debug.Log("delete button");
        Destroy(_currentSectedGameObject);
    }

    public void SelectEntered(SelectEnterEventArgs args)
    {
        _currentSectedGameObject = args.interactableObject.transform.gameObject;
        _deleteButton.interactable = true;
    }

    public void SelectExited(SelectExitEventArgs args)
    {
        _deleteButton.interactable = false;
    }
}
