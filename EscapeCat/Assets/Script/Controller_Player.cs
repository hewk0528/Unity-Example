using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_STANDALONE_WIN
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {   
            //왼쪽이동
            transform.Translate(-3, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //오른쪽이동
            transform.Translate(3, 0, 0);
        }
#endif
    }

#if UNITY_IOS || UNITY_ANDROID
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
#endif
}