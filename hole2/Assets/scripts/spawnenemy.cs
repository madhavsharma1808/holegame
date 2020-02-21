using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemy : MonoBehaviour
{
    [SerializeField] GameObject enemyprefab;
    [SerializeField] int count=0;

    void Start()
    {
        StartCoroutine(enemy());
    }
    IEnumerator enemy()
    {
        
        while (count<10)
        {
                float randomx = Random.Range(0.8f, 12f);
                float randomy = Random.Range(1f, 9f);
                Vector3 coordinates = new Vector3(randomx, randomy, 0);
                var newnemey = Instantiate(enemyprefab, coordinates, Quaternion.identity) as GameObject;
                count++;
                yield return new WaitForSeconds(5);
            
        }
    }
}
