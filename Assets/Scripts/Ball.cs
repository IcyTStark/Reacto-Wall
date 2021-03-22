using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Inspector parameters
    [SerializeField] Paddle paddleObj;
    [SerializeField] float xDirection = 1f;
    [SerializeField] float yDirection = 1f;
    [SerializeField] float zDirection = 1f;
    [SerializeField] float randomFactorX = 2f;
    [SerializeField] float randomFactorZ = 2f;

    Vector3 diffOfBallAndPaddle;
    bool hasStarted = false;

    //Cached Reference
    Rigidbody rb;
    void Start()
    {
        diffOfBallAndPaddle = transform.position - paddleObj.transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(hasStarted != true)
        {
            StickOnPaddle(); //Ball Follows the paddle until it launches
            LaunchTheBall(); //Function to launch the ball
        }
    }

    private void StickOnPaddle() 
    {
        Vector3 PaddlePos = new Vector3(paddleObj.transform.position.x, paddleObj.transform.position.y , paddleObj.transform.position.z);
        transform.position = PaddlePos + diffOfBallAndPaddle;
    }

    private void LaunchTheBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector3(xDirection, yDirection, zDirection) * Time.deltaTime;
            hasStarted = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Vector3 tweakDirection = new Vector3(UnityEngine.Random.Range(0, randomFactorX) * Time.deltaTime, 
                                             0f,
                                             UnityEngine.Random.Range(0, randomFactorZ) * Time.deltaTime);
        rb.velocity += tweakDirection;
    }

}
