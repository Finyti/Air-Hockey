using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 20;
    void Update()
    {

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        if (mousePos.x <= -4.8) mousePos.x = -4.8f;
        if (mousePos.x >= 0) mousePos.x = 0;
        if (mousePos.y >= 2.5) mousePos.y = 2.5f;
        if (mousePos.y <= -2.5) mousePos.y = -2.5f;


        var finalPosition = Vector3.MoveTowards(transform.position, mousePos, speed * Time.deltaTime);
        GetComponent<Rigidbody2D>().MovePosition(finalPosition);
    }
}
