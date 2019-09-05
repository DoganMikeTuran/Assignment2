using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text scoreText;
    private float pickedPowerups;
    public AudioClip sound;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public GameObject ring;
    public GameObject ring2;
    public GameObject ring3;
    public GameObject ring4;
    private bool truefalse = true;
    private Vector3 offset = new Vector3(0, 10, -30);
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < ring.transform.position.y + 6 && transform.position.y > ring.transform.position.y - 6 && transform.position.x < ring.transform.position.x + 6 && transform.position.x > ring.transform.position.x - 6 && transform.position.z < ring.transform.position.z + 6 && transform.position.z > ring.transform.position.z - 6)
        {
            if (truefalse == true)
            {
                source.PlayOneShot(sound);
                pickedPowerups += 1;
                truefalse = false;
                print(pickedPowerups);
                scoreText.text = pickedPowerups.ToString();
            }
        }
        if (transform.position.y < ring2.transform.position.y + 6 && transform.position.y > ring2.transform.position.y - 6 && transform.position.x < ring2.transform.position.x + 6 && transform.position.x > ring2.transform.position.x - 6 && transform.position.z < ring2.transform.position.z + 6 && transform.position.z > ring2.transform.position.z - 6)
        {
            if (truefalse == false)
            {
                source.PlayOneShot(sound);
                pickedPowerups += 1;
                truefalse = true;
                print(pickedPowerups);
                scoreText.text = pickedPowerups.ToString();
            }
        }
        if (transform.position.y < ring3.transform.position.y + 6 && transform.position.y > ring3.transform.position.y - 6 && transform.position.x < ring3.transform.position.x + 6 && transform.position.x > ring3.transform.position.x - 6 && transform.position.z < ring3.transform.position.z + 6 && transform.position.z > ring3.transform.position.z - 6)
        {
            if (truefalse == true)
            {
                source.PlayOneShot(sound);
                pickedPowerups += 1;
                truefalse = false;
                print(pickedPowerups);
                scoreText.text = pickedPowerups.ToString();
            }


        }
        if (transform.position.y < ring4.transform.position.y + 6 && transform.position.y > ring4.transform.position.y - 6 && transform.position.x < ring4.transform.position.x + 6 && transform.position.x > ring4.transform.position.x - 6 && transform.position.z < ring4.transform.position.z + 6 && transform.position.z > ring4.transform.position.z - 6)
        {
            if (truefalse == false)
            {
                source.PlayOneShot(sound);
                pickedPowerups += 1;
                truefalse = true;
                print(pickedPowerups);
                scoreText.text = pickedPowerups.ToString();
            }


        }
    }
}
