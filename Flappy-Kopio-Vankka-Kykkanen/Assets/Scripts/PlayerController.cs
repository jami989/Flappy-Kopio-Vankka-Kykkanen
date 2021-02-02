using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public bool isGameOver = false;
    public float speed = 1;
    private float animLength = 5.0f;
    private Gamemanager gameManager;
    public Text scoreText;
    // public float yRange = 4;

    private Rigidbody2D rigidBody;
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        gameManager = GetComponent<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isGameOver)
        {
            //Jump
            isGameOver = false;
            rigidBody.velocity = Vector2.up * speed;
            playerAnim.Play("PlayerJump");
        }
        else if(Input.GetMouseButtonUp(0) && !isGameOver)
        {
            playerAnim.Play("PlayerSwim");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            isGameOver = true;
            playerAnim.Play("PlayerDeath");
            Debug.Log("Game Over");
            StartCoroutine(DelayedScene(playerAnim.GetCurrentAnimatorStateInfo(0).length*animLength));
        }
        IEnumerator DelayedScene(float delay=10.0f)
        {
            yield return new WaitForSeconds(delay);
            SceneManager.LoadScene("GameOverScene");
            gameManager.text1 = scoreText;
        }
    }
}
