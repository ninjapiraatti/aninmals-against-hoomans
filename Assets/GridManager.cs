using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;

    [SerializeField] private Tile _tilePrefab;

    [SerializeField] private Transform _cam;
    private List<Tile> _tiles = new List<Tile>();

    void Start() {
        GenerateGrid();
    }

    void GenerateGrid() {
        for (int x = 0; x < _width; x++) {
            for (int y = 0; y < _height; y++) {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";
                _tiles.Add(spawnedTile);
            }
        }

        _cam.transform.position = new Vector3((float)_width/2 -0.5f, (float)_height/2 -0.5f, -10);
    }

    public Tile GetNearestTile(Vector3 position)
    {
        Tile nearestTile = null;
        float minDistance = float.MaxValue;

        foreach (var tile in _tiles)
        {
            float distance = Vector3.Distance(tile.transform.position, position);
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestTile = tile;
            }
        }

        return nearestTile;
    }
}
