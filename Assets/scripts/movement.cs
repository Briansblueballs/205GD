using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject hazard;
    public GameObject[] hazards;
    Vector3 startPos;
    public AudioClip death;
    AudioSource player;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        player = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W key pressed");
            transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.position += Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up;
        }
        for (int i = 0; i < hazards.Length; i++)
        {
            if (transform.position == hazards[i].transform.position)
            {
                transform.position = startPos;
                player.PlayOneShot(death, .75f);
            }
        }
    }
}
