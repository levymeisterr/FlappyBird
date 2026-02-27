using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.5f;
    private Vector2 screenBounds;
    

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*Time.deltaTime*speed);
        if(transform.position.x < screenBounds.x*-1.5)
        {
            //Debug.Log("Pipe destroyed");
            Destroy(this.gameObject);
        }
    }
    
    
}
