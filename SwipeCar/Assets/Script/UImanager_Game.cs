using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager_Game : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    float length = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = "목표지점까지" + length.ToString("F2") + "m";//F2= float 2자리수까지 보여줌
    }
}
