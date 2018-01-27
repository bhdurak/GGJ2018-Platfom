using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    [Header("UI Elements")]
    public GameObject timeholder;
    public GameObject hintholder;
    public GameObject winPanel;
    public GameObject losePanel;

    public GameObject endPoint;

    private Text timeText;
    private Text hintText;
    private float timeleft = 121;
    private Rigidbody2D rb2d;
    private Vector2 velocity;
    public Camera mainCam;
    public Camera blackCam;
    Color myBlue = new Color32(0x31, 0x4D, 0x79, 0x00);
    private int hintCount = 0;

	// Use this for initialization
	void Start () {
        //mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        rb2d = GetComponent<Rigidbody2D>();
        timeText = timeholder.GetComponent<Text>();
        hintText = hintholder.GetComponent<Text>();
        Debug.Log(transform);
        Time.timeScale = 1f;
        blackCam.enabled = false;
        mainCam.enabled = true;
        StartCoroutine("TurnOffCam");
    }
	
	// Update is called once per frame
	void Update () {
        hintText.text = (hintCount^1).ToString();
        timeleft -= Time.deltaTime;
        timeText.text = ((int)timeleft).ToString();
        if((int)timeleft == 0)
        {
            GameOver();
        }
        velocity.x = 0;
        velocity.y = 0;
        Movement();
        if(hintCount < 1)
        {
            Hint();
        }
        
	}

    void Movement ()
    {
        if (Input.GetKey("up"))
        {
            //transform.Translate(0, speed * Time.deltaTime, 0);
            //velocity.x = 0;
            velocity.y = 15;
            rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            //transform.Translate(0, -1 * speed * Time.deltaTime, 0);
            //velocity.x = 0;
            velocity.y = -15;
            rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            //transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
            velocity.x = -15;
            //velocity.y = 0;
            rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            //transform.Translate(speed * Time.deltaTime, 0, 0);
            velocity.x = 15;
            //velocity.y = 0;
            rb2d.MovePosition(rb2d.position + velocity * Time.deltaTime);
        }
    }

    void Hint()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            hintCount++;
            Debug.Log("H");
            StartCoroutine(TurnOnCam());
        }
    }

    void GameOver()
    {
        Time.timeScale = 0f;
        losePanel.SetActive(true);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EndPoint"))
        {
            Time.timeScale = 0f;
            winPanel.SetActive(true);
        }
    }

    IEnumerator TurnOffCam()
    {
        Debug.Log("TurnOff");
        yield return new WaitForSeconds(0.7f);
        mainCam.enabled = false;
        blackCam.enabled = true;
    }

    IEnumerator TurnOnCam()
    {
        Debug.Log("TurnOn");
        //mainCam.backgroundColor = myBlue;
        //mainCam.orthographicSize = 17;
        blackCam.enabled = false;
        mainCam.enabled = true;
        yield return new WaitForSeconds(0.9f);
        //mainCam.backgroundColor = Color.black;
        //mainCam.orthographicSize = 0;
        mainCam.enabled = false;
        blackCam.enabled = true;
    }
}
