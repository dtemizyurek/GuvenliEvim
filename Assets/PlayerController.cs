using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;

    Vector3 velocity;

    bool IsGrounded;

    public Transform ground;
    public float distance = 0.3f;

    public float speed;
    public float gravity;

    public LayerMask mask;

    public void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    public void Update()
    {
        #region Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * speed * Time.deltaTime);

        #endregion


    }


}
