using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddStone : MonoBehaviour
{
    private bool isEntered;
    [SerializeField] private GameObject itemObject;

    void Start()
    {
        isEntered = false;
    }

    void Update()
    {
        if (isEntered == true && Input.GetKeyDown(KeyCode.E))
        {
            itemObject.SetActive(false);
            InventorySystem.stone += 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        isEntered = true;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        isEntered = false;
    }
}
