using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    private Vector2 startPos;
    public float repeatWidth;
    public float movementSpeed;

    // Start is called before the first frame update

    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * movementSpeed);

        if (transform.position.x < startPos.x - repeatWidth)
        {
           transform.position = startPos;
        } 
        
    }
}
