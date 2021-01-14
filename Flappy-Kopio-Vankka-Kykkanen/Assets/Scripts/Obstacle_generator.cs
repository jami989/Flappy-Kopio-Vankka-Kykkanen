using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_generator : MonoBehaviour
{
    public float begin;
    public float spawnintervals;

    public GameObject Obstacle;

    float position;

    float starttimer;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        starttimer = Time.realtimeSinceStartup;

        if (starttimer > begin && starttimer > timer)
        {
            position = Random.Range(2f, 7.5f);
            Instantiate(Obstacle, new Vector2(13, position), Quaternion.identity);
            Instantiate(Obstacle, new Vector2(13, position - 8.5f), Quaternion.identity);

            timer = Time.realtimeSinceStartup + spawnintervals;
        }
    }
}
