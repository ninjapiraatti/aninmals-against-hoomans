using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileType
{
    Grass,
    Concrete,
}

public class Tile : MonoBehaviour
{
    private SpriteRenderer _renderer;
    public TileType tileType;

    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    public void UpdateAppearance(Boolean isHighlighted)
    {
        // Change the sprite based on the tile type
        if (isHighlighted)
        {
            _renderer.color = Color.cyan;
        }
        else
        {
            switch (tileType)
            {
                case TileType.Grass:
                    _renderer.color = Color.green; // Change to grass color
                    break;
                case TileType.Concrete:
                    _renderer.color = Color.gray; // Change to concrete color
                    break;
                // Add more cases for different tile types
                default:
                    _renderer.color = Color.white; // Default color
                    break;
            }
        }
    }

    public void OnAttack()
    {
        // Logic for what happens when the tile is attacked
        Debug.Log($"{gameObject.name} has been attacked!");
        // You can add more logic here, such as reducing health, changing state, etc.
    }
}