using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BeatMachine : MonoBehaviour {
	public float currentBPM = 120.0f;
	public float currentBeatTime;
	// Use this for initialization
	void Start () {
		currentBeatTime = currentBPM / (60.0f * 4.0f);
	}

	public void UpdateBPM(float newBPM) {
		currentBPM = newBPM;
		currentBeatTime = currentBPM / (60.0f * 4.0f);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
