using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    public float speed = 1.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.left*Time.deltaTime*speed);
        if(transform.position.x < -20.16f)
        {
            transform.position = new Vector3(20.15f, transform.position.y, transform.position.z);
        }
    }
}
