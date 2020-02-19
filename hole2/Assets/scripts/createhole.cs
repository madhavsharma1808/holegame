using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createhole : MonoBehaviour
{
    [SerializeField] GameObject loop;
    [SerializeField] GameObject again;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 shift = new Vector3(0, 0, 0);

        if (collision.gameObject.tag=="wall right")
        {
            shift = new Vector3(0.9f, 0, 0);
        }
       
        else if (collision.gameObject.tag == "wall left")
        {
            shift = new Vector3(-1.2f, 0, 0);
        }
        
        else if (collision.gameObject.tag == "wall up")
        {
            shift = new Vector3(0, 0.9f, 0);
        }
        
        else if (collision.gameObject.tag == "wall down")

        {   
            shift = new Vector3(0, -0.9f, 0);
        }


        var looper=Instantiate(loop, transform.position+shift, Quaternion.identity) as GameObject;
        transform.position = again.transform.position;
    }


}
