using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private int SceneNum;

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(SceneNum);
    }
}
