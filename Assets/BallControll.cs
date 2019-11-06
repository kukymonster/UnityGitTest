using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BallControll : MonoBehaviour
{
    public float speed;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, -speed, ForceMode.Impulse);
    }

    void Update()
    {
        if(transform.position.y < 0){
            SceneManager.LoadScene("Level1");
        }
        if(Input.GetKeyDown("r")){
            transform.position = new Vector3(0, 0.25f, 0);
            
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            var heading = col.gameObject.transform.position - transform.position;
            var direction = -heading / heading.magnitude;
            GetComponent<Rigidbody>().velocity = direction * speed;
        }
        else if(col.gameObject.tag == "Block")
        {
            Destroy(col.gameObject);
        }
    }

    

}
