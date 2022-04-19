using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball_POS : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    bool hit = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Ball_White(Clone)"))
        {
            GameObject b = GameObject.Find("Ball_White(Clone)");
            float distance = Vector3.Distance(this.transform.position, b.transform.position);
            Mathf.Floor(distance);
            int m = (int)distance;
            if (b.GetComponent<lineOn>().hitting())
            {
                text.text = m + "M";
            }

        }
    }
}
