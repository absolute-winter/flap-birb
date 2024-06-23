using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength = 10;
    public LogicScript logic;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.isPaused)
        {
            return;
        }

        if ( (Input.GetKeyDown(KeyCode.Space)) && isAlive )
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }

        if(transform.position.y <= -25 || transform.position.y >= 25)
        {
            GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }

    private void GameOver()
    {
        logic.GameOver();
        isAlive = false;
    }
}
