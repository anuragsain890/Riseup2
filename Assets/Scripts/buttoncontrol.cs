using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoncontrol : MonoBehaviour
{
    public void startbtn(string newgamelvl)
    {
        SceneManager.LoadScene(newgamelvl);

    }
    public void exitgamebtn()
    {
        Application.Quit();
    }
}
