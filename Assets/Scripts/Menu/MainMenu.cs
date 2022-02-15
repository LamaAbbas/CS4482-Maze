
/**
 *      Lama Abbas - 251035313
 *      App 2
 *      MainMenu class
 *      Sets the button's behaviours
 */
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void StartGame() {
        SceneManager.LoadScene(1);
    }

    public void ExitGame() {
        Application.Quit();
    }
}
