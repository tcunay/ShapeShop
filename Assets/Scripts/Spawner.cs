using System.Collections;
using System.Collections.Generic;
using Game.Shapes;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private ShapeAsset[] _shapeAssets;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var asset = _shapeAssets[Random.Range(0, _shapeAssets.Length)];
            GameObject shape = Instantiate(asset.Model);
            var renderer = shape.GetComponent<Renderer>();
            renderer.material.color = asset.Color;
        }
    }
}
