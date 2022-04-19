using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("bye", 10);
    }
    void bye ()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
