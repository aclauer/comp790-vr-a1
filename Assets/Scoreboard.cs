using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public static int score = 0;

    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = score.ToString();
    }
}
