using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    [SerializeField] private Color[] colors;

    private void Start()
    {
        GameManager.instance.colorManager = this;
    }

    public Color[] GetColors()
    {
        return colors;
    }
}
