using System;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    public ParticleSystem pSystem;
    public GameManager scoreScript;

    public static event EventHandler<EventArgs> OnBallHitTrampoline = delegate { };

	// Use this for initialization
	void Start () {
        scoreScript = GameObject.Find("GameManager").GetComponent<GameManager>();
        pSystem = GetComponentInChildren<ParticleSystem>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            //Score Point
            OnBallHitTrampoline(this, null);
            //Particle effect
            pSystem.Play();
        }

    }
}
