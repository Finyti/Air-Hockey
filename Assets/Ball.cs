using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class Ball : MonoBehaviour
{

    public TMP_Text PlayerScore;
    public TMP_Text EnemyScore;

    public AudioClip firstAudio;
    public AudioClip secondAudio;
    public AudioClip thirdAudio;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var source = GetComponent<AudioSource>();
        if (collision.gameObject.name.Contains("Player") || collision.gameObject.name.Contains("Enemy"))
        {
            source.pitch = UnityEngine.Random.Range(0.9f, 1.1f);
            source.volume = 0.4f + collision.relativeVelocity.magnitude / 50f;
            source.PlayOneShot(firstAudio);
        }
        if (collision.gameObject.name.Contains("Wall"))
        {
            source.pitch = UnityEngine.Random.Range(1.1f, 1.3f);
            source.volume = 0.3f + collision.relativeVelocity.magnitude / 25f;
            source.PlayOneShot(secondAudio);
        }

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

            source.pitch = UnityEngine.Random.Range(1.1f, 1.3f);
            source.volume = 0.3f + collision.relativeVelocity.magnitude / 25f;
            source.PlayOneShot(thirdAudio);
        }

        if (collision.gameObject.name.Contains("EnemyGate"))
        {
            transform.position = Vector3.right;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            int Text = int.Parse(PlayerScore.text);
            Text++;
            PlayerScore.text = Text.ToString();

            source.pitch = UnityEngine.Random.Range(1.1f, 1.3f);
            source.volume = 1 + Text / 25f;
            source.PlayOneShot(thirdAudio);
        }

    }
    void Update()
    {
        
    }
}
