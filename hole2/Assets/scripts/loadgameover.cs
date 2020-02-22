using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadgameover : MonoBehaviour
{

    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
    }



    void Update()
    {


        if (Input.GetAxis("Submit") == 1)
        {
            SceneManager.LoadScene("gameover");
        }
    }
}
