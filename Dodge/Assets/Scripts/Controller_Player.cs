using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Player : MonoBehaviour
{
    Rigidbody playerRigidbody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidbody.AddForce(0.0f, 0.0f, speed);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidbody.AddForce(0.0f, 0.0f, -speed);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.AddForce(speed, 0.0f, 0.0f);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.AddForce(-speed, 0.0f, 0.0f);
        }
        */
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0.0f, zSpeed);

        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);

        Manager_Game gameManager = FindObjectOfType<Manager_Game>();
        gameManager.EndGame();
    }
}
