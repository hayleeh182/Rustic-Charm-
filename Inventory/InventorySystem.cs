using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    [HideInInspector] public static int maple = 0;
    [HideInInspector] public static int cherry = 0;
    [HideInInspector] public static int pine = 0;

    // Legacy
    [HideInInspector] public static int wood = 0;
    [HideInInspector] public static int stone = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Amount of maple: " + maple);
            Debug.Log("Amount of cherry: " + cherry);
            Debug.Log("Amount of pine: " + pine);
        }
    }
}
