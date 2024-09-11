using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private SpriteRenderer _renderer;

    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    public void Highlight(bool isHighlighted)
    {
        Debug.Log(isHighlighted);
        if (isHighlighted)
        {
            _renderer.color = Color.yellow; // Or any color you prefer
        }
        else
        {
            _renderer.color = Color.white; // Original color
        }
    }

    public void OnAttack()
    {
        // Logic for what happens when the tile is attacked
        Debug.Log($"{gameObject.name} has been attacked!");
        // You can add more logic here, such as reducing health, changing state, etc.
    }
}