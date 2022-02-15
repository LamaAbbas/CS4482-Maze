
/**
 *      Lama Abbas - 251035313
 *      App 2
 *      Timer class
 *      Sets up the timer's behaviour
 */
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour {

    [SerializeField] private TMP_Text timerText;
    private float startTime;
    private float actualTime = 10000;
    private bool completed = false;
    private string minutes;
    private string seconds;

    private void Start() {
        startTime = Time.time;
    }

    private void Update() {
        if (completed) {
            return;
        } else {
            actualTime = Time.time - startTime;

            minutes = ((int) actualTime / 60).ToString();
            seconds = (actualTime % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }
    }

    public void Completed() {
        completed = true;
        timerText.color = Color.yellow;
        PlayerPrefs.SetFloat("actualTime", actualTime);
    }
}

