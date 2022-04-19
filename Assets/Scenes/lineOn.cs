using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineOn : MonoBehaviour
{
    bool hit = false;
    public bool hitting()
    {
        return hit;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "PC_Baseball_Bat_04 1")
        {
            hit = true;
        } 
        //gameObject.GetComponent<LinePathTracing>().enabled = true;
    }
}
