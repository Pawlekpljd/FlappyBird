using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject prefabCoin;
    public float height = 5;
    public float repeatRate = 1;
    private float timer;

    private void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnCoin();
        }
        timer += Time.deltaTime;
    }



    public void SpawnCoin()
    {
        GameObject newCoin = Instantiate(prefabCoin);
        newCoin.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);  
        Destroy(newCoin, 10f);
    }


}
