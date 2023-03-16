using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetBounds : MonoBehaviour
{
    private float minX, maxX;
    private BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        
        Vector2 worldCoordinates = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        minX= -worldCoordinates.x + boxCollider.size.x/2;
        maxX= worldCoordinates.x - boxCollider.size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPos = transform.position;
        if (currentPos.x < minX) { currentPos.x = minX; }
        if (currentPos.x > maxX) { currentPos.x = maxX; }
        transform.position = currentPos;
    }
}
