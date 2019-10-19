using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 10.0f;

    protected Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        var playerRigidbody2d = GetComponent<Rigidbody2D>();
        playerRigidbody2d.velocity = new Vector2(joystick.Horizontal * movementSpeed * Time.deltaTime, joystick.Vertical * movementSpeed * Time.deltaTime);
    }
}
