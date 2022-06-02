using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{

    Player player;
    Rigidbody2D rb;
    timer timer;

    [SerializeField]
    GameObject restartText;
    [SerializeField]
    GameObject startText;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        rb = player.GetComponent<Rigidbody2D>();
        timer = FindObjectOfType<timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.alive == false && Input.GetKeyUp(KeyCode.Space))
        {
            print("restart");
            restartText.SetActive(false);
            startText.SetActive(true);
            timer.time = 0;
            player.alive = true;
            rb.gravityScale = 0;
            player.transform.position = new Vector3(-6.23f, 0.43f, 0);
            GameObject[] hinders = GameObject.FindGameObjectsWithTag("Hinder");
            foreach (GameObject h in hinders)
                GameObject.Destroy(h);


        }
    }
}
