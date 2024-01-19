using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class FurnitureManager : MonoBehaviour
{
    [SerializeField]
    private FurnitureData[] _furnitureData;

    [SerializeField]
    private Transform _contentTransform;

    [SerializeField]
    private FurnitureMenuOption _furnitureUIPrefab;

    private FurnitureMenuOption _currentMenuOption;

    [SerializeField]
    private ARPlacementInteractable _placementInteractable;

    // Start is called before the first frame update
    void Start()
    {
        foreach(FurnitureData data in _furnitureData)
        {
            FurnitureMenuOption menuOption = Instantiate(_furnitureUIPrefab, _contentTransform);
            menuOption._nameText.text = data.name;
            menuOption._iconImage.texture = data.FurnitureIcon;
            menuOption._button.onClick.AddListener(() => SelectFurniture(menuOption, data));
        }
    }

    private void SelectFurniture(FurnitureMenuOption newMenuOption, FurnitureData furnitureData)
    {
        if(_currentMenuOption != null)
        {
            _currentMenuOption._backgroundImage.color = newMenuOption._backgroundImage.color;
        }
        _currentMenuOption = newMenuOption;
        _placementInteractable.placementPrefab = furnitureData.FurniturePrefab;
        newMenuOption._backgroundImage.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
