using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatSack : MonoBehaviour
{

    private bool dirRight = false;
    public float speed = 1.0f;
    public bool eat;
    private bool eating;

    public float leftdistance = 4.0f;
    public float rightdistance = 4.0f;

    private Vector2 SpawnPosition;

    private Animator anim;

    public AudioSource audiosource;
    public AudioClip eatsound;

    public WorldManager WorldScript;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        eating = false;
        anim = gameObject.GetComponent<Animator>();
        SpawnPosition = new Vector2(this.transform.position.x, this.transform.position.y);
    }

    void Update()
    {
        anim.SetBool("Eat", eat);
        if (!eating)
        {
            if (dirRight)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(-Vector2.right * speed * Time.deltaTime);
            }

            if (transform.position.x >= SpawnPosition.x + rightdistance)
            {
                dirRight = false;
                transform.localScale = new Vector3(1, .06666667f, 1);
            }

            if (transform.position.x <= SpawnPosition.x - leftdistance)
            {
                dirRight = true;
                transform.localScale = new Vector3(-1, .06666667f, 1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            eating = true;
            this.eat = true;
            audiosource.PlayOneShot(eatsound, 1.0f);

            Destroy(other.gameObject);
            WorldScript.CreateNewPlayer();
        }
        if(other.gameObject.tag == "Body")
        {
            eating = true;
            this.eat = true;
            audiosource.PlayOneShot(eatsound, 1.0f);

            Destroy(other.gameObject);
        }
        Invoke("StopEating", 2.0f);
    }

    void StopEating()
    {
        this.eat = false;
        eating = false;
    }
}