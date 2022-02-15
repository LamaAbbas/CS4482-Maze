
/**
 *      Lama Abbas - 251035313
 *      App 2
 *      CameraController class
 *      Allows camera to remain in 3rd person
 */
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {
    
    [SerializeField] float rotationSpeed = 1;
    [SerializeField] Transform Target, Player;
    private float mouseX, mouseY;

    private void Start() {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update() {
        if (PauseMenu.GameIsPaused) {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        } else {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private void LateUpdate() {
        if (PauseMenu.GameIsPaused) {
            ;
        } else {
            CamControl();
        }
    }

    private void CamControl() {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);
        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);
    }
}
