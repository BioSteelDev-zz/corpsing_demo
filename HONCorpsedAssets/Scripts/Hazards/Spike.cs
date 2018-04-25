using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour {

    public GameObject blood;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Instantiate(blood, new Vector3(this.gameObject.transform.position.x, this.transform.position.y, 0.0f), Quaternion.identity);
            Invoke("DestroyBlood", 1.0f);
        }
    }

    void DestroyBlood()
    {
        GameObject dblood = GameObject.FindGameObjectWithTag("Blood");
        Destroy(dblood);
    }
}
