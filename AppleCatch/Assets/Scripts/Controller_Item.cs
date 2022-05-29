using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Item : MonoBehaviour
{
    public float dropSpeed = -0.003f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, dropSpeed, 0);

        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}
