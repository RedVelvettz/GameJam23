using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class ScriptCamera : MonoBehaviour
{
    public GameObject Alex;
    public Vector3 TargetPos;

    public float HaciaAdelante;
    public float smoothing;
    private void Start()
    {

    }

    private void Update()
    {
        TargetPos = new Vector3(Alex.transform.position.x, Alex.transform.position.y, transform.position.z);

        if (Alex.transform.localScale.x == 1) //DERECHA 
        {
            TargetPos = new Vector3(TargetPos.x + HaciaAdelante, TargetPos.y, TargetPos.z);
        }

        if (Alex.transform.localScale.x == 1)  //IZQUIERDA
        {
            TargetPos = new Vector3(TargetPos.x - HaciaAdelante, TargetPos.y, TargetPos.z);
        }

        transform.position = Vector3.Lerp(transform.position, TargetPos, smoothing * Time.deltaTime);
    }
}
