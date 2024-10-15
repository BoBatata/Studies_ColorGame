using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerBehavior : MonoBehaviour
{
    private Rigidbody2D rigibody;
    private SpriteRenderer spriteRenderer;

    [Header("Movement Variables")]
    [SerializeField]private int jumpForce;

    private void Awake()
    {
        rigibody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        GameManager.instance.inputManager.touch += MoveUP;

        Color[] colors = GameManager.instance.colorManager.GetColors();
        spriteRenderer.color = colors[Random.Range(0, colors.Length)];
    }

    private void MoveUP()
    {
        rigibody.velocity = new Vector3(rigibody.velocity.x, jumpForce);
    }

    public SpriteRenderer GetSpriteRenderer()
    {
        return spriteRenderer;
    }
}
