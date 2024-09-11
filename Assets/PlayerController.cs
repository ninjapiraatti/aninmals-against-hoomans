using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;
    [SerializeField] private GridManager gridManager;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    private Tile lastHighlightedTile;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        UpdateNearestTile();

        // Check for attack input
        if (Input.GetButtonDown("Fire1")) // You can change "Fire1" to any other input if needed
        {
            Attack();
        }
    }

    void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }

    void UpdateNearestTile()
    {
        Tile nearestTile = gridManager.GetNearestTile(transform.position);
        //Debug.Log(nearestTile);

        if (nearestTile != lastHighlightedTile)
        {
            if (lastHighlightedTile != null)
            {
                lastHighlightedTile.UpdateAppearance(false);
            }
            nearestTile.UpdateAppearance(true);
            lastHighlightedTile = nearestTile;
        }
    }

    void Attack()
    {
        if (lastHighlightedTile != null)
        {
            lastHighlightedTile.OnAttack(); // Call the attack method on the nearest tile
        }
    }
}
