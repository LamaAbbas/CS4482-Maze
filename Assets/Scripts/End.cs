
/**
 *      Lama Abbas - 251035313
 *      App 2
 *      End class
 *      Handles what happens when player reaches the end
 */
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

    [SerializeField] public TMP_Text score;
    private bool complete = false;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            other.SendMessage("Completed");
            complete = true;
        }
        Invoke("loadEnd", 2.0f);
    }

    public void loadEnd() {
        SceneManager.LoadScene(2);
    }

    public bool gameEnded() {
        return complete;
    }
}
