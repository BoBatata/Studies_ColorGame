using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitePhaseManager : MonoBehaviour
{
    [SerializeField] private GameObject[] phaseObjects;

    [SerializeField] private List<GameObject> currentObjects = new List<GameObject>();

    [SerializeField] private Vector3 objOffSet;

    [SerializeField] bool test;


    private void Start()
    {
        SpawnObjects(transform);
    }

    private void Update()
    {
        if (test)
        {
            DeletePreviousObjs();
        }
    }

    public void SpawnObjects(Transform posToSpawnFrom)
    {
        for (int i = 0; i < phaseObjects.Length; i++)
        {
            GameObject obj = Instantiate(phaseObjects[i], posToSpawnFrom.position += objOffSet, Quaternion.identity);
            currentObjects.Add(obj);
        }
    }

    public void DeletePreviousObjs()
    {
        foreach (GameObject obj in currentObjects)
        {
            Destroy(obj.gameObject);
        }
        currentObjects.Clear();
    }
}
