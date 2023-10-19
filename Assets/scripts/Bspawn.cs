using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bspawn : MonoBehaviour
{
    public GameObject Espawner;
    public bool stop = false;
    public float sTime;
    public float sDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", sTime, sDelay);
    }

    // Update is called once per frame
    void spawn()
    {
       
        Vector3 RandomSpawnPosition = new Vector3(Random.Range(-20, 11), 10, Random.Range(10, 15));
        Instantiate(Espawner, RandomSpawnPosition, Quaternion.identity);
    }
}
