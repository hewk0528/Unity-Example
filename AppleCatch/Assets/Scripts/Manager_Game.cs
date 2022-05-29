using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_Game : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText;
    GameObject generator;

    public float time = 10.0f;
    int point = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
        this.generator = GameObject.Find("Generator_Item");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;

        if (this.time < 0)
        {
            this.time = 0;
            this.generator.GetComponent<Generator_Item>().SetParameter(10000.0f, 0, 0);
        }
        else if (0 <= this.time && this.time < 5)
        {
            this.generator.GetComponent<Generator_Item>().SetParameter(0.9f, -0.04f, 3);
        }
        else if (0 <= this.time && this.time < 10)
        {
            this.generator.GetComponent<Generator_Item>().SetParameter(0.4f, -0.06f, 6);
        }
        else if (0 <= this.time && this.time < 15)
        {
            this.generator.GetComponent<Generator_Item>().SetParameter(1.0f, -0.03f, 2);
        }

        this.timerText.GetComponent<Text>().text = this.time.ToString("F1");
        this.pointText.GetComponent<Text>().text = this.point.ToString()+point;
    }

    public void GetApple()
    {
        this.point += 100;
    }
    public void GetBomb()
    {
        this.point /= 2;
    }
}
