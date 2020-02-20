using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createhole : MonoBehaviour
{
    [SerializeField] GameObject loop;
    GameObject firsthole;
    int flag = 0;
    int flag2 = 1;
    Vector3 currentpos;



    public void Start()
    {
        Vector3 firstholecordinates = new Vector3(7.555f, 9.659f,-3.4f);
        firsthole = Instantiate(loop, firstholecordinates, Quaternion.identity);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
       if(flag2==1)
        {
           currentpos = transform.position;
            flag2 = 0;
        }

       
        Vector3 shift = new Vector3(0, 0, 0);
        
        if (collision.gameObject.tag=="wall right")
        {
            shift = new Vector3(1.2f, 0, -3.5f);
        }
       
        else if (collision.gameObject.tag == "wall left")
        {
            shift = new Vector3(-1.2f, 0,-3.5f);
        }
        
        else if (collision.gameObject.tag == "wall up")
        {
            shift = new Vector3(0, 0.9f, -3.5f);
        }
        
        else if (collision.gameObject.tag == "wall down")

        {   
            shift = new Vector3(0, -0.9f,-3.5f);
        }

        transform.position = firsthole.transform.position+shift;
        
       
        
        if (flag==0)
        {
           
            var looper = Instantiate(loop, transform.position + shift, Quaternion.identity) as GameObject;
            flag = 1;
        }
        else
        {
            firsthole.transform.position = currentpos + shift;
        }
        
       
    }


}
