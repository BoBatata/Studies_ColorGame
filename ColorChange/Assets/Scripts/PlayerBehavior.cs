using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerBehavior : MonoBehaviour
{
    private Rigidbody2D rigibody;
    private SpriteRenderer spriteRenderer;
    private Color[] colors;

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

        colors = GameManager.instance.colorManager.GetColors();
        SetRandomColor();
    }

    private void SetRandomColor()
    {
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ColorChange"))
        {
            SetRandomColor();
        }

        if (collision.collider.CompareTag("PointObj"))
        {
            GameManager.instance.AddPlayerPoints(1);
        }
    }
}
