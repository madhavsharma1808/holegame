using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyplayer : MonoBehaviour
{
    [SerializeField] int lifecount=3;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
            lifecount--;
        if(lifecount<=0)
            Destroy(gameObject);
    }
    
        
    
}
