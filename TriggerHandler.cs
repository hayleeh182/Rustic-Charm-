using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHandler : MonoBehaviour
{
    [SerializeField] public GameObject Object;

    private void Start()
    {
        Object.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Object.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Object.SetActive(false);
    }
}
