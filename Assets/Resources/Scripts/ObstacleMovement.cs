using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private Rigidbody rb;
    private bool osccilator =false;
    private float counter = 1.5f;
    public float speed = 1f;
    private static float lastCountvalue = 0f ;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(counter <=-2.15f)
        osccilator = true;
        if(counter>=1.5f)
        osccilator = false;

        if(osccilator)
            counter += (speed + counter)*Time.deltaTime;
        else
            counter -= (speed + counter)*Time.deltaTime;

       rb.transform.position = new Vector3(rb.transform.position.x, rb.transform.position.y,rb.transform.position.z + counter - lastCountvalue);  
       lastCountvalue=counter;
    }
}
