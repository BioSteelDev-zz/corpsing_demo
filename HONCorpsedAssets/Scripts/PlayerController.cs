using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject[] Body;
    public WorldManager WorldScript;
    public GameObject OptionsObject;

    public float maxSpeed = 3f;
    public float speed = 50f;
    public float jumpPower = 150f;

    public bool grounded;
    public bool isDead;
    public bool Sui;

    public GameObject blood;

    private bool bodyOrient;
    private bool optionsOpen;

    private Rigidbody2D rb2d;
    private Animator anim;

    public AudioSource audioItem;
    public AudioClip deathAudio;
    public AudioClip jumpAudio;

    // Use this for initialization
    void Start () {
        audioItem = GetComponent<AudioSource>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        isDead = true;
        optionsOpen = false;
        Sui = false;
        bodyOrient = false; //false is right, true is left
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Grounded", grounded); //takes the bool from the animator and sets it to the script value
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("CommitSui", Sui);

        if (!Sui) //Don't let the player move if committing Seppuku
        {
            if (Input.GetAxis("Horizontal") < -0.1f)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                bodyOrient = true;
            }

            if (Input.GetAxis("Horizontal") > 0.1f)
            {
                transform.localScale = new Vector3(1, 1, 1);
                bodyOrient = false;
            }

            //Jumping
            if (Input.GetButtonDown("Jump")) //spacebar
            {
                if (grounded)
                {
                    rb2d.AddForce(Vector2.up * jumpPower);
                    audioItem.PlayOneShot(jumpAudio, 1.0f);
                }
            }
            //Suicide
            if (Input.GetButtonDown("Fire1") && grounded)
            {
                audioItem.PlayOneShot(deathAudio, 1.0f);
                Sui = true;
                rb2d.velocity = new Vector2(0.0f, 0.0f);
                Invoke("Suicide", .5f);
            }

            if (this.gameObject.transform.position.y < -6.0f)
            {
                WorldScript.CreateNewPlayer();
                Destroy(this.gameObject);
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            
            if (GameObject.FindGameObjectWithTag("1"))
            {
                Destroy(GameObject.FindGameObjectWithTag("1"));
                WorldScript.LevelOne();
            }
            else if (GameObject.FindGameObjectWithTag("2"))
            {
                Destroy(GameObject.FindGameObjectWithTag("2"));
                WorldScript.LevelTwo();
            }
            else if (GameObject.FindGameObjectWithTag("3"))
            {
                Destroy(GameObject.FindGameObjectWithTag("3"));
                WorldScript.LevelThree();
            }
            else if (GameObject.FindGameObjectWithTag("4"))
            {
                Destroy(GameObject.FindGameObjectWithTag("4"));
                WorldScript.LevelFour();
            }
            else if (GameObject.FindGameObjectWithTag("5"))
            {
                Destroy(GameObject.FindGameObjectWithTag("5"));
                WorldScript.LevelFive();
            }
            else if (GameObject.FindGameObjectWithTag("6"))
            {
                Destroy(GameObject.FindGameObjectWithTag("6"));
                WorldScript.LevelSix();
            }
            else if (GameObject.FindGameObjectWithTag("7"))
            {
                Destroy(GameObject.FindGameObjectWithTag("7"));
                WorldScript.LevelSeven();
            }
            else if (GameObject.FindGameObjectWithTag("8"))
            {
                Destroy(GameObject.FindGameObjectWithTag("8"));
                WorldScript.LevelEight();
            }
            else if (GameObject.FindGameObjectWithTag("9"))
            {
                Destroy(GameObject.FindGameObjectWithTag("9"));
                WorldScript.LevelNine();
            }
            else if (GameObject.FindGameObjectWithTag("10"))
            {
                Destroy(GameObject.FindGameObjectWithTag("10"));
                WorldScript.LevelTen();
            }
        }

        if (Input.GetButtonDown("Fire3"))
        {
            if (optionsOpen == false)
            {
                Instantiate(OptionsObject);
                optionsOpen = true;
            }
            else
            {
                Destroy(GameObject.FindGameObjectWithTag("OptionsObject"));
                optionsOpen = false;
            }
            //Application.Quit();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Kill the player without creating a body
        if(collision.gameObject.tag == "Spike" || collision.gameObject.tag == "Undertaker")
        {
            WorldScript.CreateNewPlayer();
            Instantiate(blood, new Vector3(this.gameObject.transform.position.x, this.transform.position.y, 0.0f), Quaternion.identity);
            Invoke("DestroyBlood", 1.0f);
            Destroy(this.gameObject);
        }
    }

    void DestroyBlood()
    {
        GameObject dblood = GameObject.FindGameObjectWithTag("Blood");
        Destroy(dblood);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "NextLevelGrave")
        {
            //Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "Meatsack")
        {
            //WorldScript.CreateNewPlayer();
        }
    }

    //physics
    void FixedUpdate()
    {
        if (!Sui) //Don't let the player move if committing Seppuku
        {
            Vector3 easeVelocity = rb2d.velocity;
            float h = Input.GetAxis("Horizontal");

            easeVelocity.y = rb2d.velocity.y;
            easeVelocity.z = 0.0f;
            easeVelocity.x *= 0.75f;

            //simulate friction
            if (grounded)
            {
                rb2d.velocity = easeVelocity;
            }

            //player movement
            rb2d.AddForce((Vector2.right * speed) * h);
            //rb2d.AddForce((Vector2.right * speed));

            //If the velocity is greater than maxSpeed, set to maxSpeed, so it doesn't go flying
            if (rb2d.velocity.x > maxSpeed)
            {
                rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
            }
            //if you go the opposite direction
            if (rb2d.velocity.x < -maxSpeed)
            {
                rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
            }
        }
    }

    // Create dead body object in the players position
    void Suicide()
    {
        GameObject players = GameObject.FindGameObjectWithTag("Player");
        Vector2 playerpos = players.transform.position;
        //Debug.Log(playerpos);
        if(bodyOrient)
            Instantiate(Body[0], new Vector3(playerpos.x, playerpos.y - .9f, 0.0f), Quaternion.identity);

        if(!bodyOrient)
            Instantiate(Body[1], new Vector3(playerpos.x, playerpos.y - .9f, 0.0f), Quaternion.identity);
        GetComponent<SpriteRenderer>().enabled = false;
        WorldScript.CreateNewPlayer();
        Destroy(this.gameObject);
    }
}
