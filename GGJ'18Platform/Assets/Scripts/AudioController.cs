using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour {

    [Header ("Objects")]
    public GameObject character;
    public GameObject target;

    [Header("Sounds")]
    public AudioSource slow;
    public AudioSource mid;
    public AudioSource strongmid;
    public AudioSource strongfast;

    private Vector3 distanceVec;
    private float distance;
	// Use this for initialization
	void Start () {
        distanceVec = (target.transform.position) - (character.transform.position);
        distance = distanceVec.magnitude;
        Debug.Log(distance);
    }
	
	// Update is called once per frame
	void Update () {
        distanceVec = (target.transform.position) - (character.transform.position);
        distance = distanceVec.magnitude;
        if(distance >= 28 && distance <=40)
        {
            if(!slow.isPlaying && Time.timeScale != 0)
            {
                slow.Play();
            }
        }
        else if(distance < 28 && distance >= 19)
        {
            if (!mid.isPlaying && Time.timeScale != 0)
            {
                mid.Play();
            }
        }
        else if (distance < 19 && distance >= 9)
        {
            if (!strongmid.isPlaying && Time.timeScale != 0)
            {
                strongmid.Play();
            }
        }
        else if (distance < 9)
        {
            if (!strongfast.isPlaying && Time.timeScale!=0)
            {
                strongfast.Play();
            }
        }
    }
}
