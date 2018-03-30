using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    public string scoreLabel = "Score: ";

    private int displayedScore = -1;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if(displayedScore != gameManager.score) {
            Text text = GetComponentInChildren<Text>();
            text.text = "Score: " + gameManager.score.ToString();
        }		
	}
}
