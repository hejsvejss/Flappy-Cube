using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    
    [Range(-5f,5f)]
    public static float scrollSpeed = 2f;
    Player player;
    private float offset;
    private Material mat;
    
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        player = FindObjectOfType<Player>();
    }
    
    void Update()
    {
        if(player.playing == true)
        {
            offset += (Time.deltaTime * scrollSpeed) / 10f;
            mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        }
        
    }
}
