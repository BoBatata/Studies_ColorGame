using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InfinitePhaseManager : MonoBehaviour
{
    [SerializeField] private GameObject[] phaseObjects;

    [SerializeField] private GameObject[] currentObjects;
    [SerializeField] private GameObject[] previousObjects;

    [SerializeField] private Vector3 objOffSet;


    private void Start()
    {
        SpawnObjects();
    }

    private void SpawnObjects()
    {
        for (int i = 0; i < phaseObjects.Length; i++)
        {
            Instantiate(phaseObjects[i], transform.position += objOffSet, Quaternion.identity);
        }
    }
}
