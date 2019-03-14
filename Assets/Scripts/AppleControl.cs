using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleControl : MonoBehaviour
{
    private float bottomOfScreen = -450;
    public Text livesText;
    public int lives = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomOfScreen)
        {
            Destroy(this.gameObject);
            LivesScript.lives -= 1;
        }
    }
}
