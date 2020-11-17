using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballGenerator : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject ballPrefabMov1;
    public GameObject ballPrefabMov2;
    public int nrStillBalls;
    public int nrMov1Balls;
    public int nrMov2Balls;


    // Update is called once per frame

    private void Start()
    {
        for (int i = 0; i < nrStillBalls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 15f);
            Instantiate(ballPrefab, new Vector3(x, y, z), Quaternion.identity);
        }
        for (int i = 0; i < nrMov1Balls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 15f);
            Instantiate(ballPrefabMov1, new Vector3(x, y, z), Quaternion.identity);
        }
        for (int i = 0; i < nrMov2Balls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 15f);
            Instantiate(ballPrefabMov2, new Vector3(x, y, z), Quaternion.identity);
        }
    }

    void Update()
    {
      
    }
}
