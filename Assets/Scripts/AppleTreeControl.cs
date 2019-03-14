using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTreeControl: MonoBehaviour
{
    private int minimumSpeed = 400;
    private int maximumSpeed = 1000;
    private float leftEdge = -750f;
    private float rightEdge = 740f;
    private Vector3 startPosition = new Vector3(0f, 250f, 0f);
    private float speed;
    public bool startGame;
    private float chanceToChangeDirection = 0.015f;
    public GameObject applePrefab;
    public float secondsBetweenAppleDrops = 0.40f;

    // Start is called before the first frame update
    void Start()
    {
        startGame = false;
        startPosition = transform.position;
        speed = Random.Range(minimumSpeed, maximumSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetKeyDown(KeyCode.Space))
        {
            if (!startGame)
            {
                startGame = true;
                InvokeRepeating("DropApple", 0.5f, secondsBetweenAppleDrops);
            }

        }

        if (startGame)
        {
            Vector3 position = transform.position;
            position.x += speed * Time.deltaTime;
            transform.position = position;


            if (transform.position.x <= leftEdge)
            {
                speed = Random.Range(minimumSpeed, maximumSpeed);
                speed = Mathf.Abs(speed);
            }
            if (transform.position.x >= rightEdge)
            {
                speed = Random.Range(minimumSpeed, maximumSpeed);
                speed = -Mathf.Abs(speed);
            }
        }
    }

    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirection)
        {
            speed *= -1;
        }
    }

    void DropApple()
    {
        Instantiate(applePrefab, transform.position, Quaternion.identity);
    }

}
