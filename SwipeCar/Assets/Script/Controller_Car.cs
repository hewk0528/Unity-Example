using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Car : MonoBehaviour
{
    float speed = 0.0f;
    float swipeLength = 0.0f;
    Vector2 v2starPos;
    Vector2 v2endPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.v2starPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            this.v2endPos = Input.mousePosition;
            swipeLength = this.v2endPos.x - this.v2starPos.x;
            this.speed = swipeLength / 500.0f;

            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed, 0, 0);
        this.speed = this.speed * 0.98f;
    }
}
