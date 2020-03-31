using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalDestroy : MonoBehaviour
{
    public float deadTimer = 8f;


    public void Update()
    {
        deadTimer -= Time.deltaTime;

        if(deadTimer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
