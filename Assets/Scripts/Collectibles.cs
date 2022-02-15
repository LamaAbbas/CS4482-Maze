
/**
 *      Lama Abbas - 251035313
 *      App 2
 *      Collectibles class
 *      Allows the interaction with fruits
 */
using UnityEngine;

public class Collectibles : MonoBehaviour {

    private Rigidbody fruit;

    private void Awake() {
        fruit = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            gameObject.SetActive(false);
        }
    }
}
