using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketMovementKeys : MonoBehaviour
{
    private float speed = 800f;
    Vector3 startPosition = new Vector3(0f, -425f, 0f);
    private float leftEdge = -750f;
    private float rightEdge = 740f;
    public float x;
    public bool startGame;
    private bool mouseMove = false;
    public Text scoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        startGame = false;
        startPosition = transform.position;
        Vector3 position = transform.position;
        Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetKeyDown(KeyCode.Space))
        {
            startGame = true;
        }

        if (startGame)
        {

            if (Input.GetKey(KeyCode.RightArrow) && !mouseMove)
            {
                this.gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.LeftArrow) && !mouseMove)
            {
                this.gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            }

            else
                mouseMove = false;

            Vector3 pos = transform.position;
            if (pos.x < -775) pos.x = -775;
            if (pos.x > 765) pos.x = 765;
            transform.position = pos;
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {                            
        GameObject collidedWith = collision.gameObject;                          
        if (collidedWith.tag == "Apple" && collidedWith != null)
        {   
            Destroy(collidedWith);
            ScoreScript.currentScore += 10;
        }                          
    }
}
