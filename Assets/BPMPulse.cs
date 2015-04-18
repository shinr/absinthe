using UnityEngine;
using System.Collections;

public class BPMPulse : MonoBehaviour {
	public float bpm = 120.0f;
	public float maxIntensity = 1.0f;
	public float lightDecreaseRate = .95f;
	float rate = 0.0f;
	Light light;
	// Use this for initialization
	void Start () {
		rate = (bpm / 60.0f) / 4.0f;
		light = GetComponent<Light>();
		Invoke("Blink", rate);
	}
	
	void Blink() {
		light.intensity = maxIntensity;
		Invoke("Blink", rate);
	}

	// Update is called once per frame
	void Update () {
		if(light.intensity > 0.0f) {
			light.intensity *= lightDecreaseRate;
		}
	}
}
