using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_generator : MonoBehaviour
{
    public float begin;
    public float spawnintervals;

    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public GameObject Goal;

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
            position = Random.Range(1.75f, 6.5f);
            Instantiate(Obstacle2, new Vector2(15, position), Quaternion.identity);
            Instantiate(Obstacle1, new Vector2(15, position - 8.5f), Quaternion.identity);
            Instantiate(Goal, new Vector2(15, position - 4), Quaternion.identity);

            timer = Time.realtimeSinceStartup + spawnintervals;
        }
    }
}
