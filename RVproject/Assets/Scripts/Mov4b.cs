using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov4b : MonoBehaviour{

    public float speed = 2.5f;
    float x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(x*Mathf.PingPong(Time.time * speed, -5), y, z);
        transform.position = new Vector3(x, y*Mathf.PingPong(Time.time * speed, -5), z);
        transform.position = new Vector3(x, y, z*Mathf.PingPong(Time.time * speed, -5));

    }
    public void setSpeed(float s)
    {
        speed = s;
    }
}
