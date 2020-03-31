using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticals : MonoBehaviour
{
    public GameObject fireball;
    float shootingSpeed = 30000;
    public Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        SpawnFireBall();
    }

    // Update is called once per frame
   
    void SpawnFireBall()
    {
        GameObject fireballProject = Instantiate(fireball, transform.position, Quaternion.identity) as GameObject;
      
        rb2D = fireballProject.GetComponent<Rigidbody2D>();
        rb2D.AddForce(Vector3.left * shootingSpeed * Time.deltaTime);
        
    }
}
