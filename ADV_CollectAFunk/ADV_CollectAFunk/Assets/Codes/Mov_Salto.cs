using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Salto : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    private Animator avatarAnim;
    public float x, y;
    public Rigidbody rb;
    public float jumpForce = 100.0f;
    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        avatarAnim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
        avatarAnim.SetBool("Grounded", true);
    }

    void FixedUpdate(){
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * movementSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        avatarAnim.SetFloat("VelX", x);
        avatarAnim.SetFloat("VelY", y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        avatarAnim.SetBool("Jump", true);
        avatarAnim.SetBool("Grounded", false);
        isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Ground") {
        avatarAnim.SetBool("Jump", false);
        avatarAnim.SetBool("Grounded", true);
        isGrounded = true;
        }
    }

}
