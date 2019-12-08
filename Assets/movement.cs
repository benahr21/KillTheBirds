using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb1;
    private float thrust = 10.0f;
    void Start()
    {
        rb1 = gameObject.AddComponent<Rigidbody2D>();
        transform.position = new Vector3(0.0f, -2.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb1.AddForce(transform.up * thrust);
        }
    }
}
