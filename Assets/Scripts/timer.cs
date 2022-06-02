using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    TMPro.TMP_Text uiText;
    public bool alive;
   public float time = 0;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<TMPro.TMP_Text>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = time.ToString("F1");
        if (player.playing == true)
        {
            time += Time.deltaTime;
        }
        
        if (time > 10)
        {

        }
    }
}
