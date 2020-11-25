using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov5 : MonoBehaviour
{

    float angle = 0;
    public float speed = (2*Mathf.PI)/5;
    float radius = 5;
    float x, y, z;


    // Start is called before the first frame update
    void Start()
    {
        x =  transform.position.x;
        y =  transform.position.y;
        z =  transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {//Mathf.Sin(angle)radius / 4  (Mathf.PingPong(Time.time * speed, 5)
        angle += speed * Time.deltaTime;

        transform.position = new Vector3(x * Mathf.Cos(angle)*radius / 5, y * Mathf.Sin(angle)*radius / 4, transform.position.z);
    }
    public void setSpeed(float s)
    {
        speed = s;
    }

}
