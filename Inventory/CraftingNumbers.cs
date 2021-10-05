using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CraftingNumbers : MonoBehaviour
{
    public TextMeshProUGUI GUIobject;

    // Make sure this is set to a resource with the first letter in caps
    // If not the GUI will show "Error"
    [SerializeField] private string resourceName;

    void Start()
    {
        GUIobject = GUIobject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (resourceName == "Maple")
        {
            GUIobject.SetText(resourceName + ": " + InventorySystem.maple.ToString());
        }
        else if (resourceName == "Pine")
        {
            GUIobject.SetText(resourceName + ": " + InventorySystem.pine.ToString());
        }
        else if (resourceName == "Cherry")
        {
            GUIobject.SetText(resourceName + ": " + InventorySystem.cherry.ToString());
        }
        // Legacy
        // if (resourceName == "Wood")
        // {
        //     GUIobject.SetText(resourceName + ": " + InventorySystem.wood.ToString());
        // }
        // else if (resourceName == "Stone")
        // {
        //     GUIobject.SetText(resourceName + ": " + InventorySystem.stone.ToString());
        // }
        else
        {
            GUIobject.SetText("Error");
        }
    }
}
