using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1f;
    private float timer = 0;
    public float heightOffset = 3;

    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(highestPoint, lowestPoint), 0), transform.rotation);
    }
}
