using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{
    public Transform player;
    public Transform dowpos;
    public Transform upperpos;
    public Transform elevatorswitch;

    public float speed;
    bool iselevatordown;
   


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("sube");
            if (transform.position.y <= dowpos.position.y)
            {
                iselevatordown = true;
            }
            else if (transform.position.y >= upperpos.position.y)
            {
                iselevatordown = false;
            }

        }
        if (iselevatordown)
        {
            transform.position = Vector2.MoveTowards(transform.position, upperpos.position, speed);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, dowpos.position, speed);
        }
    }


}
