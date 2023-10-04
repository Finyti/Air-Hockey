using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class Ball : MonoBehaviour
{

    public TMP_Text PlayerScore;
    public TMP_Text EnemyScore;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Gate"))
        {
            GameObject.Find("Player").transform.position = new Vector3(-3, 0, 0);
            GameObject.Find("Enemy").transform.position = new Vector3(3, 0, 0);
        }
        if (collision.gameObject.name.Contains("PlayerGate"))
        {
            transform.position = Vector3.left;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            int Text = int.Parse(EnemyScore.text);
            Text++;
            EnemyScore.text = Text.ToString();
        }

        if (collision.gameObject.name.Contains("EnemyGate"))
        {
            transform.position = Vector3.right;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            int Text = int.Parse(PlayerScore.text);
            Text++;
            PlayerScore.text = Text.ToString();
        }

    }
    void Update()
    {
        
    }
}
