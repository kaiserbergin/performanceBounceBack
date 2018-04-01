using System;
using UnityEngine;

public class ScoreUpdatedArgs : EventArgs {
    public int Score { get; set; }

    public ScoreUpdatedArgs(int score) {
        Score = score;
    }
}

public class GameManager : MonoBehaviour {

    public int score;
    public static event EventHandler<ScoreUpdatedArgs> OnScoreUpdated = delegate { };

    private void Awake() {
        Trampoline.OnBallHitTrampoline += IncreaseScore;
    }

    private void IncreaseScore(object sender, EventArgs args) {
        score++;
        OnScoreUpdated(this, new ScoreUpdatedArgs(score));
    }
}
