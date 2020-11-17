using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov5 : MonoBehaviour
{

    float angle = 0;
    public float speed = (2*Mathf.PI)/5;
    float radius = 5;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {//Mathf.Sin(angle)radius / 4  (Mathf.PingPong(Time.time * speed, 5)
        angle += speed * Time.deltaTime;

        transform.position = new Vector3(Mathf.Cos(angle)*radius / 5, Mathf.Sin(angle)*radius / 4, transform.position.z);
    }


}
