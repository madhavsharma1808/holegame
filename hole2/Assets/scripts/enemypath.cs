using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypath : MonoBehaviour
{

    [SerializeField] float speed = 4f;
    [SerializeField] GameObject playerobject;
    void Update()
    {
        if (GameObject.Find("player"))
        {
            var obj = FindObjectOfType<destroyplayer>().returnlife();
            if (obj == 0)
            {

                var player = FindObjectOfType<playermovement>().returncoordinates();
                var speedrandom = Random.Range(1f, speed);
                float randomx = Random.Range(0.8f, 12f);
                float randomy = Random.Range(1f, 9f);

                transform.position = Vector2.MoveTowards(transform.position, player, speedrandom * Time.deltaTime);

            }
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetType() == typeof(CircleCollider2D))
        {
            float x = Random.Range(-12, 12);
            float y = Random.Range(-12, 12);


            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x, y);
        }
    }
}
