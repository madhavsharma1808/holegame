using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypath : MonoBehaviour
{

    [SerializeField] float speed = 1f;
    void Update()
    {
        var player = FindObjectOfType<playermovement>().returncoordinates();

        transform.position = Vector2.MoveTowards(transform.position, player, speed * Time.deltaTime);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetType() == typeof(CircleCollider2D))
        {
            float x = Random.Range(0.1f, 2f);
            float y = Random.Range(0.1f, 2f);


            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x, y);
        }
    }
}
