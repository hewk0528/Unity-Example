using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Bullet : MonoBehaviour
{
    Rigidbody bulletRigidbody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Controller_Player playerController = other.GetComponent<Controller_Player>();

            if (playerController != null)
            {
                playerController.Die();
            }
        }
    }
}
