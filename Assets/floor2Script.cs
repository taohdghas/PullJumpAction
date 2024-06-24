using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class floor2Script : MonoBehaviour
{
    public int speed;
    private Vector3 startPos;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(transform.position);
        float PosX = startPos.x + Mathf.PingPong(Time.time * speed, 8) - 2;
        rb.MovePosition(new Vector3(PosX, startPos.y, startPos.z));
    }
}
