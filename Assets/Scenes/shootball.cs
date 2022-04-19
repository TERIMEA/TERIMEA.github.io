using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample { 
        public class shootball : MonoBehaviour
    {
        public HoverButton hoverButton;

        public GameObject prefab;
        public GameObject pitcher;
        public GameObject shotpos;
        public GameObject endpos;
        private void Start()
        {
            hoverButton.onButtonDown.AddListener(OnButtonDown);
        }
        private void Update()
        {

        }
        private void OnButtonDown(Hand hand)
        {
            Destroy(GameObject.Find("Ball_White(Clone)"));
            Destroy(GameObject.Find("Line_0"));
            GameObject shooter = Instantiate(pitcher) as GameObject;
            shooter.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            shooter.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            Invoke("go", 2.2f);
        }
        void go()
        {
            StartCoroutine(repos(prefab));
        }
        private IEnumerator repos(GameObject prefab)
        {
            GameObject ball = Instantiate(prefab) as GameObject;
            int Vx = Random.Range(-200, 200);
            int Vy = Random.Range(200, 300);
            Vector3 speed = new Vector3(Vx, Vy, 7000);
            ball.transform.position = shotpos.transform.position;
            ball.GetComponent<Rigidbody>().AddForce(speed);
            yield return null;
        }
    }
}