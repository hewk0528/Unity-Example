using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Camera : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("cat");    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playPos;
        playPos = this.player.transform.position;
        transform.position = new Vector3 (transform.position.x, playPos.y, transform.position.z);
    }
}
