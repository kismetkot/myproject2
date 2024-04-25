using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.CompareTag("Coin")) {
            Destroy(collider.gameObject);
        }

        if ((collider.gameObject.CompareTag("Buff")) && (transform.localScale.x < 2f)) {
            Destroy(collider.gameObject);
            transform.localScale = transform.localScale + new Vector3(0.2f, 0.2f, 0.2f);
        }
    }

    void OnCollisionEnter(Collision collision){
        if ((collision.gameObject.CompareTag("Obstacle")) && (transform.localScale.x > 0.2f)) {
            transform.localScale = transform.localScale - new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}
