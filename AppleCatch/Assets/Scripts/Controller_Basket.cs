using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Basket : MonoBehaviour
{   
    GameObject manager;
    AudioSource aud;

    public AudioClip appleSE;
    public AudioClip bombSE;
    

    // Start is called before the first frame update
    void Start()
    {   
        this.manager = GameObject.Find("Manager_Game");
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()   
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);

                transform.position = new Vector3(x, 0.0f, z);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Apple") 
        {
            //Debug.Log("Apple");
            this.manager.GetComponent<Manager_Game>().GetApple();
            this.aud.PlayOneShot(this.appleSE);
        }
        else if(other.gameObject.tag == "Bomb")
        {
            //Debug.Log("Bomb");
            this.manager.GetComponent<Manager_Game>().GetBomb();
            this.aud.PlayOneShot(this.bombSE, 0.5f);
        }
        Destroy(other.gameObject);
    }
}
