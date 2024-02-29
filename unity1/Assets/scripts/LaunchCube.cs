using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float thrust = 1.0f;
    public Rigidbody rb;


    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("space key was pressed");
            rb.AddForce(0, 6, 0, ForceMode.Impulse);
        }

    }
}
