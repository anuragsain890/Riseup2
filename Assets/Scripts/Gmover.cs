using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gmover : MonoBehaviour
{

    public void Menu_Click()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Restart_Click()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
