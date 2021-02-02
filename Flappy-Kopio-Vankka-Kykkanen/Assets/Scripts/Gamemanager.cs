using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public Text text1;
    public Text text2;

    private int Score = 0;
    private int Hscore;// = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text1.text = "Score: " + Score;
        text2.text = "High score: " + Hscore;
    }

    public void Scored()
    {
        Score++;

        if (Score > Hscore)
        {
            Hscore = Score;
        }
    }
}
