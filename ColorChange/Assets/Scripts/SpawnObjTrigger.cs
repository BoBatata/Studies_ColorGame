using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjTrigger : MonoBehaviour
{
    private Transform objTransform;
    private Collider2D objCollider;

    private void OnEnable()
    {
        objTransform = GetComponent<Transform>();
        objCollider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            objCollider.enabled = false;
            GameManager.instance.infinitePhaseManager.DeletePreviousObjs();
            GameManager.instance.infinitePhaseManager.SpawnObjects(objTransform);
        }
    }
}
