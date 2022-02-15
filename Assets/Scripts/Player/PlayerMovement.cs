
/**
 *      Lama Abbas - 251035313
 *      App 2
 *      PlayerMovement class
 * 
 */
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] private float speed;
    private Rigidbody body;
    private Animator anim;

    private void Awake() {
        body = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        body.AddRelativeForce(movement * speed, ForceMode.Impulse);

        anim.SetBool("run", horizontal != 0 || vertical != 0);
    }
}
