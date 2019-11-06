using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoHP : MonoBehaviour
{
    public int hp = 2;
    public Material scMat;
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Ball"){
            hp--;
            if(hp == 0){
                Destroy(this.gameObject);
            }
            else{
                GetComponent<MeshRenderer>().material = scMat;
            }
        }
    }
}
