using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public Text text1;
    public Text text2;

    private int Score;
    private int Hscore;

    // Start is called before the first frame update
    void Start()
    {
        text2.text = "High Score: " + PlayerPrefs.GetInt("Hscore", 0).ToString();
    }

    // Update is called once per frame

    public void Scored()
    {
        Score++;
        text1.text = "Score: " + Score;
        if (Score > PlayerPrefs.GetInt("Hscore", 0))
        {
            PlayerPrefs.SetInt("Hscore", Score);     //storing data
            text2.text = "High Score: "+ Score.ToString();
        }
    }
    public void Reset()
    {
        PlayerPrefs.DeleteKey("Hscore");
    }
}
