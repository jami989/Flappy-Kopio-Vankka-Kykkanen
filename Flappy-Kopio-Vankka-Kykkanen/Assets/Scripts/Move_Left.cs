using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Left : MonoBehaviour
{
    public GameObject gameManager;
    public Gamemanager GM;

    public float Speed;
    public int type;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController");

        GM = gameManager.GetComponent<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime); // move left

        if (transform.position.x < -13)
        {
            Destroy(gameObject); // destroy gameobject when out of screen
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && gameObject.CompareTag("Finish"))
        {
            GM.Scored();
        }
    }
}
