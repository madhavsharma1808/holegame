using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadgameagain : MonoBehaviour
{

    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
    }



    void Update()
    {


        if (Input.GetAxis("Submit") == 1)
        {
            SceneManager.LoadScene("corescene");
        }
    }
}
