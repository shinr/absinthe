using UnityEngine;
using System.Collections;

public class InsanityManager : MonoBehaviour {
	public GameObject [] bar;
	public GameObject [] danceFloor;
	public GameObject [] dancers;
	public Vector3 barPosition;
	public Vector3 danceFloorPosition;
	public Vector3 dancersPosition;
	int currentInsanity = 0;
	GameObject _bar;
	GameObject _danceFloor;
	GameObject _dancers;
	public void IncreaseInsanity() {
		currentInsanity += 1;
	}

	// Use this for initialization
	void Start () {
		_bar = (GameObject)Instantiate(bar[currentInsanity], barPosition, Quaternion.identity);
		_danceFloor = (GameObject)Instantiate(danceFloor[currentInsanity], danceFloorPosition, Quaternion.identity);
		_dancers = (GameObject)Instantiate(dancers[currentInsanity], dancersPosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
