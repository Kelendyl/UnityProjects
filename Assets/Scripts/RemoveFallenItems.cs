using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFallenItems : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        Destroy(target.gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
