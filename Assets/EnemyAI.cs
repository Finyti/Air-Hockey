using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public Transform ball;

    public float speed;

    public Transform defencePoint;

    public Vector3 targetPosition;

    private Rigidbody2D rb;

    public float moveCooldown;

    public Vector3 moveOfset;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveCooldown -=  Time.deltaTime;

        if (moveCooldown <= 0)
        {
            moveCooldown = Random.Range(0, 2f);
            moveOfset = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        }


        var canAttack = ball.position.x > 0;

        if (canAttack)
        {
            targetPosition = ball.position;
        }
        else
        {
            targetPosition = defencePoint.position;
            targetPosition += moveOfset;
        }

        var finalPosition = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        rb.MovePosition(finalPosition);
    }
}
