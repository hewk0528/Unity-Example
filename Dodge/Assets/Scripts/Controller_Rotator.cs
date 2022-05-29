using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Rotator : MonoBehaviour
{
    public float ratationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, ratationSpeed*Time.deltaTime, 0.0f);
    }
}
