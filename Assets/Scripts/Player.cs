using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool playing = false;
    AudioSource audio;
    Rigidbody2D rb;
    timer timer;
    private bool alive = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        timer = FindObjectOfType<timer>();
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            
            if (!playing)
            {
                playing = true;
                rb.gravityScale = 1;
            }
            rb.velocity = new Vector3(0, 4f, 0);
            audio.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Barrier")
        {
            timer.alive = false;
            alive = false;
            playing = false;
            BackgroundScroller.scrollSpeed = 0;
            Hinder.speed = 0;
        }
    }

}
