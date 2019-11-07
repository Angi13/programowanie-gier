using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject obstacles;
    public float height;


    // Start is called before the first frame update
    void Start()
    {
        GameObject newObstacles = Instantiate(obstacles);
        newObstacles.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newObstacles = Instantiate(obstacles);
            newObstacles.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newObstacles, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
