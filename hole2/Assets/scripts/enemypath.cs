using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypath : MonoBehaviour
{

    [SerializeField] float speed = 4f;
    void Update()
    {
        var player = FindObjectOfType<playermovement>().returncoordinates();

        var speedrandom = Random.Range(1f, speed);
        transform.position = Vector2.MoveTowards(transform.position, player, speedrandom * Time.deltaTime);

        
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
