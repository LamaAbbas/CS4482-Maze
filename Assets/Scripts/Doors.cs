/**
 *      Lama Abbas - 251035313
 *      App 2
 *      Door class
 *      Allows the interaction with doors
 */

using UnityEngine;

public class Doors : MonoBehaviour {

    [SerializeField] private Collectibles fruit;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && !fruit.gameObject.activeInHierarchy) {
            gameObject.SetActive(false);
        }
    }
}
