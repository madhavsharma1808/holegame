using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createhole : MonoBehaviour
{
    [SerializeField] GameObject loop;

    List<GameObject> holelist = new List<GameObject>();

    void Start()
    {
        StartCoroutine(holes());
    }
    public IEnumerator holes()
    {
        while (true)
        {
            float randomx = Random.Range(0.8f, 12f);
            float randomy = Random.Range(1f, 9f);
            Vector3 coordinates = new Vector3(randomx, randomy, 0);
            GameObject newhole=Instantiate(loop, coordinates, Quaternion.identity);
            holelist.Add(newhole);
            yield return new WaitForSeconds(1.5f);
        }
    }

    public List<GameObject> returnholes()
    {
        return holelist;
    }
   public void modifyholes(Collision2D collision)
    {
        if (holelist.Count > 0)
        {
            holelist.Remove(collision.gameObject);
            
        }

    }


}












