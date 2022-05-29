using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Roulette : MonoBehaviour
{
    float fRouletteRotSpeed = 0.0f;
    public float fRouletteRotMaxSpeed;
    public float fRouletteRotAccSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetMouseButtonDown(0))
        {
            this.fRouletteRotSpeed = fRouletteRotMaxSpeed;
        }
        
        if(Input.GetMouseButtonDown(1))
        {
            this.fRouletteRotSpeed = 0;
        }

        transform.Rotate(0, 0, this.fRouletteRotSpeed);

        this.fRouletteRotSpeed = this.fRouletteRotSpeed * fRouletteRotAccSpeed;

    }

}
