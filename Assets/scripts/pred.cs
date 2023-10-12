using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pred : MonoBehaviour
{
    Rigidbody rb;
    public Transform player;
    public float forceMultiplier = 2f;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Vector3.Normalize(player.position - transform.position) * forceMultiplier);  
    }
}
