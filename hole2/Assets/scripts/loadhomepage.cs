using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadhomepage : MonoBehaviour
{
     void Start()
    {
        StartCoroutine(loadnextscene());
        
    }

    IEnumerator loadnextscene()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("corescene");
    }
}
