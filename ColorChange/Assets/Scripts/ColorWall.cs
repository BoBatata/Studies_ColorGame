using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorWall : MonoBehaviour
{
    private Collider2D collider;
    private SpriteRenderer spriteRenderer;
    private SpriteRenderer playerSprite;

    private void Awake()
    {
        collider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        playerSprite = GameManager.instance.playerBehavior.GetSpriteRenderer();
        if (playerSprite.color == spriteRenderer.color)
        {
            collider.enabled = false;
            this.gameObject.tag = "Untagged";
        }
        else
        {
            collider.enabled = true;
            this.gameObject.tag = "WallColor";
        }
    }

    public void SetColor(Color color)
    {
        spriteRenderer.color = color;
    }
}
