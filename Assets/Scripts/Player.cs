using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    BackgroundScroller scroller;
    AudioSource audio;
    Rigidbody2D rb;
    private bool alive = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        scroller = FindObjectOfType<BackgroundScroller>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            rb.velocity = new Vector3(0, 4f, 0);
            
                audio.Play();

            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Barrier")
        {
            alive = false;
            scroller.scrollSpeed = 0;
            Hinder.speed = 0;
        }
    }

}
