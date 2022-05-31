using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selectbuttons : MonoBehaviour

{
    int CurrentButton;
    [SerializeField]
    Text[] buttons;
    float holdTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.Space))
        {
            holdTime += Time.deltaTime;
            
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            if (holdTime < 1)
            {
                CurrentButton += 1;
                if (CurrentButton >= buttons.Length)
                {
                    CurrentButton = 0;
                }
            }
            else
            {
                if (CurrentButton == 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    print("play game");
                }
                else if (CurrentButton == 1)
                {
                    Application.Quit();
                    print("quit game");
                }
            }
            holdTime = 0;
        }
            

        for(int i = 0; i <= 1; i++){
            if (i == CurrentButton)
                buttons[i].color = Color.yellow;
            else
                buttons[i].color = Color.black;
        
        }
    }
    }
