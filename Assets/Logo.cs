using UnityEngine;
using System.Collections;

public class Logo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Off", 15.0f);
	}

    void Off()
    {
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0.0f, -0.025f, 0.0f));
	}
}
