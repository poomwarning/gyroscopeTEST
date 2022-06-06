using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    float dx,dy;
    float movespeed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dx = Input.acceleration.x * movespeed;
        dy = Input.acceleration.y * movespeed;
        if(Input.acceleration.y >-0.5f)
        {
            dy = Mathf.Abs(dy);
            Debug.Log(true);
        }
        Debug.Log("X="+Input.acceleration.x+"Y ="+Input.acceleration.y);
        //transform.position = new Vector2(Mathf.Clamp(transform.position.x,-7.5f,7.5f), transform.position.y);
        
    }
    private void FixedUpdate() 
    {
      //  rigidbody2D.velocity = new Vector2(dx,dy);
      rigidbody2D.AddForce(new Vector2(dx,dy));
    }
}
