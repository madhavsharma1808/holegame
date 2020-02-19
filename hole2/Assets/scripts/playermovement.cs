using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    float movementspeed = 5f;
    float xmin, xmax, ymin, ymax;
    [SerializeField] float padding = 1f;
    void Update()
    {
        setcamera();
        movement();
    }

    public void setcamera()
    {
        Camera gamecamera = Camera.main;
        xmin = gamecamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x+padding ;
        xmax = gamecamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x-padding ;
        ymin = gamecamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y+padding ;
        ymax = gamecamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y -padding;

    }

    void movement()
    {
        float cordx = Input.GetAxis("Horizontal")*movementspeed*Time.deltaTime;
        float cordy = Input.GetAxis("Vertical") * movementspeed * Time.deltaTime;
        cordx = Mathf.Clamp(transform.position.x+cordx, xmin, xmax);
        cordy = Mathf.Clamp(transform.position.y+cordy,ymin,ymax);
        transform.position =new  Vector2(cordx,cordy);
    }
}

