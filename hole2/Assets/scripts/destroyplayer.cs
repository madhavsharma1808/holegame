using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyplayer : MonoBehaviour
{
    int flag = 0;
    Vector3 location = new Vector3(0.3f, 0.3f, 0.3f);
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            flag = 1;
            Destroy(gameObject);
            SceneManager.LoadScene("gameover");
            

        }

        if(collision.gameObject.tag=="holes")
        {
            List<GameObject> holelist = GetComponent<createhole>().returnholes();
            
            
            

            //Destroy(collision.gameObject);
            
            GetComponent<createhole>().modifyholes(collision);
            if (holelist.Count > 0)
            {
                int randomising = Random.Range(0, holelist.Count);
                transform.position = holelist[randomising].transform.position+location;
                Destroy(collision.gameObject);
            }
        }
    }

    public int returnlife()
    {
        return flag;
    }






}
