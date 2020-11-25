using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballGenerator : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject ballPrefabMov1;
    public GameObject ballPrefabMov1b;
    public GameObject ballPrefabMov2;
    public GameObject ballPrefabMov2b;
    public GameObject ballPrefabMov3;
    public GameObject ballPrefabMov3b;
    public GameObject ballPrefabMov4;
    public GameObject ballPrefabMov4b;
    public GameObject ballPrefabMov5;
    public int nrStillBalls;
    public int nrMov1Balls;
    public int nrMov1bBalls;
    public int nrMov2Balls;
    public int nrMov2bBalls;
    public int nrMov3Balls;
    public int nrMov3bBalls;
    public int nrMov4Balls;
    public int nrMov4bBalls;
    public int nrMov5Balls;

    // Update is called once per frame

    private void Start()
    {
        for (int i = 0; i < nrStillBalls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 10f);
            Instantiate(ballPrefab, new Vector3(x, y, z), Quaternion.identity);
        }
        for (int i = 0; i < nrMov1Balls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 10f);
            Instantiate(ballPrefabMov1, new Vector3(x, y, z), Quaternion.identity);
        }
        for (int i = 0; i < nrMov1bBalls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 10f);
            Instantiate(ballPrefabMov1b, new Vector3(x, y, z), Quaternion.identity);
        }
        for (int i = 0; i < nrMov2Balls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 10f);
            Instantiate(ballPrefabMov2, new Vector3(x, y, z), Quaternion.identity);
        }
        for (int i = 0; i < nrMov2bBalls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 10f);
            Instantiate(ballPrefabMov2b, new Vector3(x, y, z), Quaternion.identity);
        }
        for (int i = 0; i < nrMov3Balls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 10f);
            Instantiate(ballPrefabMov3, new Vector3(x, y, z), Quaternion.identity);
        }
        for (int i = 0; i < nrMov3bBalls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 10f);
            Instantiate(ballPrefabMov3b, new Vector3(x, y, z), Quaternion.identity);
        }
        for (int i = 0; i < nrMov4Balls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 10f);
            Instantiate(ballPrefabMov4, new Vector3(x, y, z), Quaternion.identity);
        }
        for (int i = 0; i < nrMov4bBalls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(4f, 10f);
            Instantiate(ballPrefabMov4b, new Vector3(x, y, z), Quaternion.identity);
        }
        for (int i = 0; i < nrMov5Balls; i++)
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-2f, 4f);
            float z = Random.Range(8f, 10f);
            Instantiate(ballPrefabMov5, new Vector3(x, y, z), Quaternion.identity);
        }
    }

    void Update()
    {
      
    }
}
