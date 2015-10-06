using UnityEngine;
using System.Collections;

public class Absinthe : MonoBehaviour {
    public Transform player;
    public GameObject walls;
    public GameObject backwall;
    public GameObject wobbler;
    public GameObject particles;
    public GameObject lightz;
    public GameObject bottle;
    bool forever = false;
	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision C)
    {
        if (!forever)
        {
            walls.transform.localScale = new Vector3(walls.transform.localScale.x, walls.transform.localScale.y, walls.transform.localScale.z * 1000.0f);
            backwall.transform.position = new Vector3(backwall.transform.position.x, backwall.transform.position.y, backwall.transform.position.z * -1000.0f);
            forever = true;
            wobbler.GetComponent<Wobble>().Play();
            particles.GetComponent<ParticleSystem>().Play();
            
         
        }
    }
	
	// Update is called once per frame
	void Update () {
        lightz.GetComponent<Light>().spotAngle = 50.0f * (1 / Mathf.Abs(player.position.z - this.transform.position.z));
        if(Mathf.Abs(player.position.z - this.transform.position.z) < 5.0f)
        {
            if(!bottle.GetComponent<ParticleSystem>().isPlaying)
            {
                bottle.GetComponent<ParticleSystem>().Play();
            }
        } else
        {
            if (bottle.GetComponent<ParticleSystem>().isPlaying)
            {
                bottle.GetComponent<ParticleSystem>().Stop();
            }
        }
    }
}
