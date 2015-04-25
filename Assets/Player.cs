using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {
	public float absintheLevel = 0.0f;
	public float clickDistance = 2.0f;
	public float [] absintheThresholds;
	float currentAbsintheThreshold = 0.0f;
	//ParticleSystem _particle;
	// Use this for initialization
	void Start () {
		//_particle = GetComponent<ParticleSystem>();
	}

	void ShootRay() {
		RaycastHit hit;
 		Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2.0f, Screen.height / 2.0f, 0f));
 		if ( Physics.Raycast(ray, out hit, 1000.000f))
 		{
 			Absinthe _bottle = hit.transform.gameObject.GetComponent<Absinthe>();
 			if(_bottle) {
 				if(Vector3.Distance(this.transform.position, hit.transform.position) < clickDistance) {
 					absintheLevel += 1.0f;
 					// _particle.Play();
 					Debug.Log("click");
 				}
 			}
 		}
	}
	
	// Update is called once per frame
	void Update () {
		float v = Input.GetAxis("Vertical");
		
		if(v != 0.0f) {
			transform.Translate(Vector3.forward * v * Time.deltaTime); 
		}
		if(Input.GetButtonDown("Fire1")) {
			Debug.Log("fire1");
			ShootRay();
		}
		if(Input.GetButtonDown("Fire2")) {
			Debug.Log("fire2");	
			ShootRay();
		}
	}
}
