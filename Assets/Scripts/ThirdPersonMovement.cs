using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public Transform cam;
    public CharacterController controller;
    public float speed = 6f;
    public float runSpeed = 10f;
    public float turnSmoothTime = 0.1f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public ParticleSystem jetpack;
    float turnSmoothVelocity;
    float velocityY;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;


            // If the player is holding shift, use runSpeed
            if (Input.GetKey(KeyCode.LeftShift)) {
                controller.Move(moveDir * runSpeed * Time.deltaTime);
            } else {
                controller.Move(moveDir * speed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.E)) {
            velocityY = 2f;
            jetpack.Play();
        } else {
            jetpack.Stop();
        }

        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            float jumpVelocity = Mathf.Sqrt(-2 * gravity * jumpHeight);
            velocityY = jumpVelocity;
        } 

        velocityY += gravity * Time.deltaTime;
        controller.Move(Vector3.up * velocityY * Time.deltaTime);
    }


}
