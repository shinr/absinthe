using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Wobble : MonoBehaviour {
	float currentAngle;
	float wobbleMultiplier = 1.0f;
	public Player player;
	public float maxAngle = 45.0f;
    bool running = false;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player").GetComponent<Player>();
	}

    public void Play()
    {
        running = true;
    }
	
	// Update is called once per frame
	void Update () {
        if(!running)
        {
            return;
        }
		float angleAdjust = wobbleMultiplier * player.absintheLevel * Time.deltaTime;
		currentAngle += angleAdjust;
		transform.Rotate(Vector3.forward * angleAdjust);
		if(currentAngle > maxAngle ||currentAngle < -maxAngle) {
			wobbleMultiplier *= -1.0f;
		}
	}
}
