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
}