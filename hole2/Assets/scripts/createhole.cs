using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createhole : MonoBehaviour
{
    [SerializeField] GameObject loop;



    void Start()
    {
        StartCoroutine(holes());
    }
    IEnumerator holes()
    {
        while (true)
        {
            float randomx = Random.Range(0.8f, 12f);
            float randomy = Random.Range(1f, 9f);
            Vector3 coordinates = new Vector3(randomx, randomy, 0);
            Instantiate(loop, coordinates, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }

}












