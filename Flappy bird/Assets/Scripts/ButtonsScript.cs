using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{


    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
       // Debug.Log("OK");
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
