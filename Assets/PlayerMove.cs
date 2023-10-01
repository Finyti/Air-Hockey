using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    void Update()
    {

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;


        GetComponent<Rigidbody2D>().MovePosition(mousePos);
    }
}
