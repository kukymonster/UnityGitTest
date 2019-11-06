using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    void OnGUI(){
        Vector2 mousePos = new Vector2();

        mousePos.x = Event.current.mousePosition.x;
        mousePos.y = Camera.main.pixelHeight - Event.current.mousePosition.y;

        Vector3 point = Camera.main.ScreenToWorldPoint(
                new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));

        transform.position = new Vector3(point.x * 10, transform.position.y, transform.position.z);
    }
}
