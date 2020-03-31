
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2 : MonoBehaviour
{
    public GameObject fireball;
   
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnFireBall();
    }

    // Update is called once per frame

    void SpawnFireBall()
    {
        Instantiate(fireball, transform.position, Quaternion.identity);
    }
}
