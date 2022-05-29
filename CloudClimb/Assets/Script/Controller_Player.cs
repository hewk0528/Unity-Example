using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_Player : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;

    public float jumpForce = 680.0f;
    public float walkForce = 680.0f;
    public float maxWalkSpeed = 680.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //jump(SpaceBar)
        if(Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        //movement
        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }

        float speedx = 0.0f;
        speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * this.walkForce * key);
        }

        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        //animation speed
        if (this.rigid2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }

        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Goal!");
        SceneManager.LoadScene("ClearScene");
    }
}
