using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_Bamsongi : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    GameObject bamsongi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            bamsongi = Instantiate(bamsongiPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            bamsongi.GetComponent<Controller_Bamsongi>().Shoot(worldDir.normalized * 2000);
        }
    }
}
