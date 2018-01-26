using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float speed = 10;
    private Rigidbody2D rb2d;
    private Vector2 velocity;


	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        //velocity.z = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    void Movement ()
    {
        if (Input.GetKey("up"))
        {
            //transform.Translate(0, speed * Time.deltaTime, 0);
            velocity.x = 0;
            velocity.y = 10;
            rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            //transform.Translate(0, -1 * speed * Time.deltaTime, 0);
            velocity.x = 0;
            velocity.y = -10;
            rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            //transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
            velocity.x = -10;
            velocity.y = 0;
            rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            //transform.Translate(speed * Time.deltaTime, 0, 0);
            velocity.x = 10;
            velocity.y = 0;
            rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EndPoint"))
        {
            Debug.Log("a");
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EndPoint"))
        {
            Debug.Log("b");
        }
    }*/
}
