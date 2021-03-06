
/**
 *      Lama Abbas - 251035313
 *      App 2
 *      PauseMenu class
 *      Handles the pausing mechanism
 */
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    [SerializeField] GameObject pauseMenuUI;

    private void Start() {
        Resume();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GameIsPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu() {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void QuitGame() {
        Application.Quit();
    }
}
