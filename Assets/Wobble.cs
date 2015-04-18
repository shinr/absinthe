using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Wobble : MonoBehaviour {
	Player player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
