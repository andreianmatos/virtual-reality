using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCursor : MonoBehaviour
{

    public AudioClip hapticSelect;

    static Color s_UnityHighlight = Color.yellow;
    float rSpeed = 0.5f;
    static Color s_UnityCyan = new Color(0.019f, 0.733f, 0.827f, 0.5f);
    GameObject nearestBall;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.parent.position;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - transform.parent.localScale.y);
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
            other.gameObject.GetComponent<Renderer>().material.color = s_UnityHighlight;
            nearestBall = other.gameObject;
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
            other.gameObject.GetComponent<Renderer>().material.color = s_UnityCyan;
            nearestBall = null;
        }
    }

    public void OnTriggerSelect()
    {
        if (nearestBall != null)
            Destroy(nearestBall);
        nearestBall = null;
    }

    public void ChangePosition(Vector2 axis2d)
    {
        Vector3 movement = new Vector3(0.0f, 1.0f, 0.0f);
        //Vector3 direction = transform.parent.parent.rotation.eulerAngles;
        if (axis2d.y > 0.1f)
            transform.Translate(rSpeed * movement.normalized * axis2d.x, transform.parent);
        else if (axis2d.y < -0.1f)
            transform.Translate(rSpeed * movement.normalized * axis2d.x, transform.parent);

    }
}