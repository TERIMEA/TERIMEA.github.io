using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample {
    public class reset : MonoBehaviour
    {
        public HoverButton hoverButton;

        public GameObject prefab;

        Vector3 rotation;
        private void Start()
        {
            hoverButton.onButtonDown.AddListener(OnButtonDown);
        }

        private void OnButtonDown(Hand hand)
        {
            StartCoroutine(repos(prefab));
        }
        private IEnumerator repos(GameObject prefab)
        {
            rotation += new Vector3(0, 0, 0) * Time.deltaTime;
            prefab.transform.position = this.gameObject.transform.position;
            yield return null;
        }
    }
}
