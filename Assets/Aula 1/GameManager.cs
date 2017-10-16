using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //how many points the player gets every time it saves the ball
    public int pointsToGrant;
    //score
    private int score;
    //canvas text
    private Text scoreText;

    private void Awake()
    {
        //start zeroed
        score = 0;
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
    }

    // Use this for initialization
    void Start () {
        //QualitySettings.antiAliasing = 80;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //update the score
    public void UpdateScore()
    {
        score += pointsToGrant;

        //update text in canvas
        scoreText.text = "Score: " + score.ToString();
    }

    //getters and setters
    public int GetScore()
    {
        return score;
    }
    public void SetScore(int value)
    {
        score = value;
    }
}
