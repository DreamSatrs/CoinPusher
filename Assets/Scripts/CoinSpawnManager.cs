using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinSpawnManager : MonoBehaviour
{
    public Transform[] coinSpawns;

    private Transform currentSpawn;

    private GameObject coinPrefab;
    private GameObject coinObj;
    // Start is called before the first frame update
    void Start()
    {
        coinPrefab = Resources.Load("Common/coin") as GameObject;

        StartCoroutine(ISpawnCoinDeafult());
    }

    IEnumerator ISpawnCoinDeafult()
    {
        for (int i = 0; i < 50; i++)
        {
            currentSpawn = coinSpawns[ Random.Range(0, 3)];
            coinObj = Instantiate(coinPrefab, currentSpawn.position, Quaternion.identity);
            coinObj.transform.parent = currentSpawn;
            coinObj.transform.localEulerAngles = new Vector3(Random.Range(0, 60), Random.Range(0, 60), Random.Range(0, 60));
            coinObj.transform.localPosition = new Vector3(Random.Range(0, 1), 0, Random.Range(-1.5f, 0));
            yield return new WaitForSeconds(0.2f);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnOnce();
        }
    }

    void SpawnOnce()
    {
        currentSpawn = coinSpawns[ Random.Range(0, 3)];
        coinObj = Instantiate(coinPrefab, currentSpawn.position, Quaternion.identity);
        coinObj.transform.parent = currentSpawn;
        coinObj.transform.localEulerAngles = new Vector3(Random.Range(0, 60), Random.Range(0, 60), Random.Range(0, 60));
        coinObj.transform.localPosition = new Vector3(Random.Range(0, 1), 0, Random.Range(-1.5f, 0));
    }
}
