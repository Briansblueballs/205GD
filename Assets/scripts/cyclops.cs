using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyclops : MonoBehaviour
{
    public float boomForce = 50f;
    public float boomRad = 20f;
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(laser, out hit)) {
            Debug.Log("connection" + hit.transform.name);

            if (Input.GetMouseButton(0) && hit.rigidbody)
            {
                hit.rigidbody.AddExplosionForce(boomForce, hit.point, boomRad);
            }

            if (Input.GetMouseButtonDown(2))
            {
                Instantiate(prefab, hit.point, Quaternion.identity);
            }


            
        }
    }
}
