using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_Item : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
   
    float delta = 0.0f;
    
    float span = 1.0f;
    float speed = -0.003f;
    int ratio = 2;

    GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0.0f;

            GameObject item;
            int dice = 0;

            dice = Random.Range(1, 11);

            if (dice <= this.ratio)
            {
                item = Instantiate(bombPrefab) as GameObject;
            }
            else
            {
                item = Instantiate(applePrefab) as GameObject;
            }

            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);

            item.transform.position = new Vector3(x, 8, z);
            item.GetComponent<Controller_Item>().dropSpeed = this.speed;
        }
    }

    public void SetParameter(float span, float speed, int ratio)
    {
        this.span = span;
        this.speed = speed;
        this.ratio = ratio;
    }
}
