using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinder : MonoBehaviour
{
    public float speed = 1.86f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * new Vector3(-2, 0, 0) * Time.deltaTime;
    }
}