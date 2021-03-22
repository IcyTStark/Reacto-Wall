using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 20f;
    [SerializeField] float miniX = 0f;
    [SerializeField] float maxiX = 16f;
    void Start()
    {
        
    }

    
    void Update()
    {
        //Debug.Log();
        Vector3 PaddlePos = new Vector3(transform.position.x,transform.position.y,transform.position.z);
        float mousePositionInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        
        PaddlePos.x = Mathf.Clamp(mousePositionInUnits, miniX, maxiX);
        transform.position = PaddlePos;
    }

   
}
