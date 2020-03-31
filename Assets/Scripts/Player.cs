using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public bool dead;
    public float gravity;
    public float jumpPower = 30;
    public Rigidbody2D rb2D;
    public SpriteRenderer player;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb2D.gravityScale *= -1;
            

        }

    }
   // private void FixedUpdate()
   // {
   //     if (rb2D.gravityScale == 1)
   //     {
   //         rb2D.AddForce(transform.up * jumpPower);
   //     }
   //     if (rb2D.gravityScale == -1)
   //     {
   //         rb2D.AddForce(-transform.up * jumpPower);
   //     }
   //
   //    
   //
   // }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("I'm Triggered");
            dead = true;
        }
    }
}
