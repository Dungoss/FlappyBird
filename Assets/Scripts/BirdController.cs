using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    [SerializeField] float flapStrength = 10f;
    public LogicScript logic;
    public bool birdAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && birdAlive) {
            rigidbody2d.velocity = Vector2.up * flapStrength;
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdAlive = false;
        logic.GameOver();
    }
}
