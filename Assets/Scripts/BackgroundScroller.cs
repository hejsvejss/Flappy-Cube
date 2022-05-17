using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    
    [Range(-5f,5f)]
    public float scrollSpeed = 2f;
    private float offset;
    private Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }
    
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}