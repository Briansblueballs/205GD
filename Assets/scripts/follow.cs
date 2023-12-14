using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform targetobj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//makes it so that the game object moves towards the targert
        transform.position =
             Vector3.MoveTowards(this.transform.position, targetobj.position, 10 * Time.deltaTime);
    }
}
