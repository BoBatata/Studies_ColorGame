using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    private Transform transform;
    private Color[] colors;
    [SerializeField] private float spinForce;
    [SerializeField] private ColorWall[] wallColors;

    private void Awake()
    {
        transform = GetComponent<Transform>();
    }

    private void Start()
    {
        colors = GameManager.instance.colorManager.GetColors();

        for (int i = 0; i < colors.Length; i++)
        {
            wallColors[i].SetColor(colors[i]);
        }       
    }

    private void Update()
    {
        transform.Rotate(0f, 0f, spinForce, Space.Self);
    }
}
