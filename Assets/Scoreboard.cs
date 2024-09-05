using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    public static int score = 0;
    public TextMesh textDisplay = new TextMesh();
    // Start is called before the first frame update
    void Start()
    {
        textDisplay.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textDisplay.text = "Score: " + score;
    }
}
