using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void loadBegin()
    {
        SceneManager.LoadScene("begin_1");
        Debug.Log("DO it");
       
    }
    public void Quit()
    {
    Application.Quit();
        Debug.Log("the play has quit the game");
    }
}
