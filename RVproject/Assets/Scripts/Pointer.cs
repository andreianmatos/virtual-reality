using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public Transform hand_pos;
    public Material BallColor;
    static Color s_UnityCyan = new Color(0.019f, 0.733f, 0.827f, 0.8f);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = hand_pos.position;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + transform.localScale.y);
        transform.parent = hand_pos;
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    void OnTriggerEnter(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Ball"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            //other.gameObject.SetActive (false);
            other.gameObject.GetComponent<Renderer>().material.color = s_UnityCyan;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("here");
            // Make the other game object (the pick up) inactive, to make it disappear
            //other.gameObject.SetActive (false);
            other.gameObject.GetComponent<Renderer>().material.color = BallColor.color;

        }
    }
}
