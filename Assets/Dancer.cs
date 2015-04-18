using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Dancer : MonoBehaviour {
	float absintheLevel = 0.0f;
	BeatMachine beatMachine;
	float myTime = 0.0f;
	float danceHeightRandomizer;
	float danceOffsetRandomizer;
	public float baseDanceHeight = 1.0f;
	float currentDanceHeight = 0.0f;
	// Use this for initialization
	void Start () {
		beatMachine = GameObject.Find("BeatMachine").GetComponent<BeatMachine>();
		danceOffsetRandomizer = absintheLevel + Random.Range(0.0f, 0.0f);
		danceHeightRandomizer = Random.Range(0.0f, 1.8f);
	}
	
	// Update is called once per frame
	void Update () {
		myTime += Time.deltaTime;
		if(myTime > beatMachine.currentBeatTime + danceOffsetRandomizer) {
			currentDanceHeight = baseDanceHeight + danceHeightRandomizer;
			myTime = 0.0f;
		}	
		if (currentDanceHeight > 0.0f) {
			transform.position = new Vector3(transform.position.x, 1.0f + currentDanceHeight, transform.position.z);
			currentDanceHeight *= 0.97f;
		}
	}
}
