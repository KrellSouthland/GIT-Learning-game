using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public bool death = true;
    public Text result;
    public Text score;
    public GameObject GOScreen;
    public void GameOver()
    {
        result.text = score.text;
        GOScreen.SetActive(true);
    }
}
