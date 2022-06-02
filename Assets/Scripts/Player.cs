using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool playing = false;
    AudioSource audio;
    Rigidbody2D rb;
    timer timer;
    [SerializeField]
    GameObject restartText;
    [SerializeField]
    GameObject startText;
    public bool alive = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            print("hopp");
            if (!playing)
            {
                startText.SetActive(false);
                print("start");
                playing = true;
                rb.gravityScale = 1;
                BackgroundScroller.scrollSpeed = 2f;
                Hinder.speed = 1.86f;
            }
            rb.velocity = new Vector3(0, 4f, 0);
            audio.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Barrier" || collision.transform.tag == "Hinder")
        {
            restartText.SetActive(true);
            alive = false;
            playing = false;
            BackgroundScroller.scrollSpeed = 0;
            Hinder.speed = 0;
        }
    }

}
