
/**
 *      Lama Abbas - 251035313
 *      App 2
 *      Leaderboard class
 *      Provides methods for buttons, allows saving and loading of names and corresponding times
 */
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Leaderboard : MonoBehaviour {

    // Variables associated with the text on the UI 
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text nameText;

    private int numPlayers = 5;
    private float playerTime;
    private string playerName;

    // These store the values of the names and their times
    public List<float> times = new List<float>();
    public List<string> names = new List<string>();
    private List<string> keys = new List<string>();

    private void Start() {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        keys.Clear();
        for (int i = 1; i <= numPlayers; i++) {
            keys.Add("player" + i);
        }
    }

    // Restarts the leaderboard
    public void EraseScores()
    {
        times.Clear();
        names.Clear();
        PlayerPrefs.DeleteAll();
    }

    // Gets the information and stores them in the lists
    public void LoadScore() {
        times.Clear();
        names.Clear();

        foreach (var key in keys) {
            string curName = PlayerPrefs.GetString(key + "_n");
            float curTime = PlayerPrefs.GetFloat(key + "_t");

            if (curName == "") {
                names.Add("---");
                times.Add(1000000);
            } else {
                names.Add(curName);
                times.Add(curTime);
            }
        }
    }

    // For display of leaderboard
    public void PrintButton() {
        LoadScore();

        for (int i = 0; i < 5; i++) {
            if (times[i] < 1000000) {
                scoreText.text += Math.Round(times[i], 2) + "\n";
            } else {
                scoreText.text += 0 + "\n";
            }
        }

        for (int i = 0; i < 5; i++) { 
            nameText.text += names[i] + "\n";
        }
    }

    // When the player submits their name
    public void SaveButton() {
        playerTime = PlayerPrefs.GetFloat("actualTime");
        playerName = PlayerPrefs.GetString("actualName").Substring(0, 3).ToUpper();
        SaveScore();
        SceneManager.LoadScene(0);
    }

    public void SaveScore() {
        LoadScore();

        // Insert player's time/name
        for (int i = 0; i < times.Count; i++) {
            if (playerTime < times[i]) {
                names.Insert(i, playerName);
                times.Insert(i, playerTime);
                break;
            }
        }
        names.RemoveAt(names.Count - 1);
        times.RemoveAt(times.Count - 1);

        // Serialize lists
        for (int i = 0; i < names.Count; i++) {
            PlayerPrefs.SetString(keys[i] + "_n", names[i]);
            PlayerPrefs.SetFloat(keys[i] + "_t", times[i]);
        }
        SceneManager.LoadScene(0);
    }
}
