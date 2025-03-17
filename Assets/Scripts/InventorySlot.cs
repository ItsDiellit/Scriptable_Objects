using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
    public ScriptableItem slotItem;

    public int slotNumber;

    public GameObject inspectionWindow;

    public Image inspectionImage;
    public Text inspectionName;
    public Text inspectionDescription;

    public Button closeButton;
    public Button deleteButton;
    // Start is called before the first frame update
    void Start()
    {
        Button thisButton = GetComponentInChildren<Button>();
        thisButton.onClick.AddListener(InspectItem);
    }

    void InspectItem()
    {
        if(slotItem != null && inspectionWindow.activeInHierarchy)
        {
            inspectionImage.sprite = slotItem.itemSprite;
            inspectionName.text = slotItem.itemName;
            inspectionDescription.text = slotItem.itemDescription;

            inspectionWindow.SetActive(true);
        }
    }

}
