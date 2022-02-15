
/**
 *      Lama Abbas - 251035313
 *      App 2
 *      UserInput class
 *      Takes the name input
 */
using UnityEngine;

public class UserInput : MonoBehaviour { 
   public void getInput(string input) {
        PlayerPrefs.SetString("actualName", input);
    }
}
