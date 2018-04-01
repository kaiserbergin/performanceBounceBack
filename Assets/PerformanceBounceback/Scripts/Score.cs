using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public string scoreLabel = "Score: ";
    private Text scoreText;

    private void Awake() {
        GameManager.OnScoreUpdated += UpdateScoreText;
    }

    // Use this for initialization
    void Start() {
        scoreText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    public void UpdateScoreText(object sender, ScoreUpdatedArgs args) {
        scoreText.text = "Score: " + args.Score.ToString();
    }
}
