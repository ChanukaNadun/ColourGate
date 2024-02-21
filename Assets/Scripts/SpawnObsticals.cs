using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObsticals : MonoBehaviour
{
    public float xRange = 3.5f;

    public int randomObstacles;
    public GameObject[] obstacle;
    public float startDelay = 50f;
    public float spawnInterval = 10f;

    public ChangePlayer changePlayer;
    

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i >= 0; i++)
        {
            InvokeRepeating("SpawnObstacles", startDelay, spawnInterval);
        }
        //SpawnObstacles();
        
    }
    //float timer = 0;

    //void Update()
    //{
    //    timer = timer + (Time.fixedTime);
    //    if (timer > 50000)
    //    {
            
    //        timer = 0;
    //        WaitForSecondsRealtime(2);
    //        timer = timer - 100;
    //    }
        
    //    Debug.Log("RandomObstacles"+obstacle.Length);
    //}
    //void WaitForSecondsRealtime(int v)
    //{
    //    InvokeRepeating("SpawnObstacles", startDelay, spawnInterval);
    //}
    void SpawnObstacles()
    {
        int randomObstacles = Random.Range(0, obstacle.Length);
        Vector2 spownPos = new Vector2(Random.Range(-xRange, xRange), 8.5f);
        Instantiate(obstacle[randomObstacles], spownPos, obstacle[randomObstacles].transform.rotation);
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if(changePlayer.cl_SR.GetComponent<SpriteRenderer>().color == obstacle[randomObstacles].GetComponent<SpriteRenderer>().color) 
    //    {
    //        SpawnObstacles();
    //    }
    //    //SpawnObstacles();
    //}
}
