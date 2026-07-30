using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public GameObject jumpSound;
    public GameObject deathSound;
    public GameObject pointSound;
    public float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            player.GetComponent<Rigidbody2D>().AddForce(transform.up*jumpForce, ForceMode2D.Impulse);
            GameObject newJumpSound;
            newJumpSound = Instantiate(jumpSound,transform.position,Quaternion.identity);
        }   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player collided with: " + collision.gameObject.name);
        GameObject newDeathSound; 
        newDeathSound = Instantiate(deathSound, transform.position, Quaternion.identity);
        GameManager.Instance.GameOver();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name== "PointTrigger")
        {
            GameManager.Instance.ScorePoint();
            GameObject newPointSound; 
            newPointSound = Instantiate(pointSound, transform.position,Quaternion.identity);
        }
    }


}
