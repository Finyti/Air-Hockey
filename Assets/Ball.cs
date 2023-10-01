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
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            GameObject.Find("Player").transform.position = new Vector3(-3, 0, 0);
            GameObject.Find("Enemy").transform.position = new Vector3(3, 0, 0);
        }
        if (collision.gameObject.name.Contains("PlayerGate"))
        {
            int Text = int.Parse(EnemyScore.text);
            Text++;
            EnemyScore.text = Text.ToString();
        }

        if (collision.gameObject.name.Contains("EnemyGate"))
        {
            int Text = int.Parse(PlayerScore.text);
            Text++;
            PlayerScore.text = Text.ToString();
        }

    }
    void Update()
    {
        
    }
}
