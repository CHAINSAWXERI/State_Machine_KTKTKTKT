using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public PlayerInput playerInput;
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] public float speed;

    public void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);

        if (playerInput.isMoving)
        {
            rb.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);
        }
    }
}
