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
        StartElevator();
    }
    void StartElevator()
    {
        if (Vector2.Distance(player.position, elevatorswitch.position) < 0.5f && Input.GetKeyDown("f"))
        {
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
            transform.position = Vector2.MoveTowards(transform.position, upperpos.position, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, dowpos.position, speed * Time.deltaTime);
        }

    }


}
