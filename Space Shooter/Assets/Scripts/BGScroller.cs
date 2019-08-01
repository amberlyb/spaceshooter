using System.Collections;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeZ;

    private int score = 0;

    private Vector3 startPosition;
    
    void Start()
    {
        
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat (Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.forward * newPosition;

        if (score >= 10)
        {
        transform.position = new Vector3 (transform.position.x, transform.position.y + (scrollSpeed * Time.smoothDeltaTime), 0);
        }
    }
}
