using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfrom : MonoBehaviour
{
    public float platfromSpeed;
    void Update()
    {
        transform.Translate(Vector3.left * platfromSpeed * Time.deltaTime);
    }
}
