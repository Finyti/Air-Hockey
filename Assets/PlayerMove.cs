using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    void Update()
    {

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        if (mousePos.x <= -4.8) mousePos.x = -4.8f;
        if (mousePos.x >= 0) mousePos.x = 0;
        if (mousePos.y >= 2.5) mousePos.y = 2.5f;
        if (mousePos.y <= -2.5) mousePos.y = -2.5f;


        GetComponent<Rigidbody2D>().MovePosition(mousePos);
    }
}
