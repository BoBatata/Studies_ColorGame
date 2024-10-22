using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rigibody;
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
        colors = GameManager.instance.colorManager.GetColors();
        SetRandomColor();
    }

    private void SetRandomColor()
    {
        spriteRenderer.color = colors[Random.Range(0, colors.Length)];
    }

    public void MoveUP()
    {
        rigibody.velocity = new Vector3(rigibody.velocity.x, jumpForce);
        if (rigibody.velocity.y < 0)
        {
            rigibody.velocity = new Vector2 (0, 0);
        }
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
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("PointObj"))
        {
            GameManager.instance.AddPlayerPoints(1);
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("WallColor"))
        {
            GameManager.instance.PlayerLose();
        }
    }
}
