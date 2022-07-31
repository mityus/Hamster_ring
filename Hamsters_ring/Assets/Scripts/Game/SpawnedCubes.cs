using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedCubes : MonoBehaviour
{
    public List<Transform> pointPositions = new List<Transform>();

    public GameObject[] prefabsCubes;
    
    private void Start()
    {
        StartCoroutine(SpawnerPosition());
    }
    
    IEnumerator SpawnerPosition()
    {
        while (true)
        {
            GameObject go = prefabsCubes[Random.Range(0, prefabsCubes.Length)];
            
            Instantiate(go, pointPositions[Random.Range(0, pointPositions.Count)].transform.position, 
                Quaternion.identity);
            
            yield return new WaitForSeconds(0.7f);
        }
    }
}
