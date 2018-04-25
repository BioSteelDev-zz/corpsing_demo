using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravehand : MonoBehaviour {

    public GameObject Undertaker;
    private bool isBlocked;
    private Vector3 utPos;

    public GameObject blood;

    public AudioSource audiosource;
    public AudioClip attack;

	// Use this for initialization
	void Start () {
        audiosource = GetComponent<AudioSource>();
        isBlocked = false;
        utPos = new Vector3(this.gameObject.transform.position.x, this.transform.position.y + 0.1f, 0.0f);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isBlocked)
        {
            if (collision.gameObject.tag == "Player")
            {
                Invoke("SpawnUndertaker", 0.1f);
                audiosource.PlayOneShot(attack, 1.0f);
            }
        }
        if(collision.gameObject.tag == "Body")
        {
            isBlocked = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Body")
        {
            isBlocked = false;
        }
    }

    void SpawnUndertaker()
    {
        Instantiate(Undertaker, utPos, Quaternion.identity);
        //Instantiate(blood, new Vector3(this.gameObject.transform.position.x, this.transform.position.y, 0.0f), Quaternion.identity);
        //Invoke("DestroyBlood", 1.0f);
        Invoke("DestroyUndertaker", 1.0f);
    }

    void DestroyUndertaker()
    {
        GameObject[] hands = GameObject.FindGameObjectsWithTag("Undertaker");
        foreach(GameObject go in hands)
        {
            Destroy(go);
        }
    }

    void DestroyBlood()
    {
        GameObject dblood = GameObject.FindGameObjectWithTag("Blood");
        Destroy(dblood);
    }
}
