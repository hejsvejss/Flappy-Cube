using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject hinder;

    private float waitTime = 2f;

    float timeBetweenSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timeBetweenSpawn += Time.deltaTime;

        if (timeBetweenSpawn > waitTime)// spawnar en fiende när väntetiden är slut
        {
            timeBetweenSpawn = 0;
            Instantiate(hinder, transform.position + new Vector3(0, Random.Range(4.5f,9), 0), Quaternion.identity);


        }
    }
}
