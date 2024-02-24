using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    [SerializeField] float flapStrength = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)) {
            rigidbody2d.velocity = Vector2.up * flapStrength;
        }
       
    }
}
