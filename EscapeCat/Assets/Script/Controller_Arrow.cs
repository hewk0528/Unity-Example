using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Arrow : MonoBehaviour
{
    GameObject player;
    Vector2 p1;
    Vector2 p2;
    Vector2 dir;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.01f, 0);
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //충돌체크
        p1 = transform.position;
        p2 = this.player.transform.position;
        dir = p1 - p2;

        float d = dir.magnitude;

        float r1 = 0.5f;
        float r2 = 1.0f;

        //충돌하면 제거
        if (d < r1 + r2)
        {
            Destroy(gameObject);

            GameObject UIManager_Game;
            UIManager_Game = GameObject.Find("UIManager_Game");
            UIManager_Game.GetComponent<UIManager_Game>().DecreaseHP();
        }
    }
}
