using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour
{
    public void LoadScene(string esena)
    {
        SceneManager.LoadScene(esena);
    }
}
