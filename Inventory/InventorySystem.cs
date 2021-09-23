using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{

    [HideInInspector] public static int wood = 0;
    [HideInInspector] public static int stone = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Amount of wood: " + wood);
            Debug.Log("Amount of stone: " + stone);
        }
    }
}
