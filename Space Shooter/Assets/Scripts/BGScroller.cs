using System.Collections;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeZ;

    private int score;

    private Vector3 startPosition;
    
    void Start()
    {
        score = 0;
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat (Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.forward * newPosition;
    }
    
}