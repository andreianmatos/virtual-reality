using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_2 : MonoBehaviour{

    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 3), transform.position.y, transform.position.z);
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * speed, 5), transform.position.z);

    }
}
