using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float horMove;
    float verMove;
    public float angle = 1.0f;
    private Rigidbody rb;
    private Quaternion q;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        horMove = -Input.GetAxis("Horizontal") * angle;
        verMove = Input.GetAxis("Vertical")* angle;

        rb.rotation =Quaternion.Euler(verMove, 0f,horMove );

    }
}
