using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    void Update()
    {
        if(transform.childCount == 0){
            if(SceneManager.GetActiveScene().name == "Level1"){
                SceneManager.LoadScene("Level2");
            }
            else{
                SceneManager.LoadScene("Level1");
            }
        }
    }

   
}
