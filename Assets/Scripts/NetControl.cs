using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetControl : MonoBehaviour
{
    private float velocity = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateMovement(Time.deltaTime);
        
    }

    void UpdateMovement(float deltaTime)
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + velocity*horizontalDirection*deltaTime ;
        transform.position = position;
    }
}
