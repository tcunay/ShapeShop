using System.Collections.Generic;
using UnityEngine;
using Game.Viewers;
using Game.Shapes;
using UnityEngine.Tilemaps;
using System.Numerics;

namespace Game.Salvers
{
    public class TilePositionsLibrary
    {
        private Vector3Int[] _positions = { new Vector3Int(2, 1, 0), new Vector3Int(4, 1, 0), new Vector3Int(3, 2, 0) };

        public Vector3Int[] Positions => _positions;
    }

    public class Salver : MonoBehaviour
    {
        [SerializeField] private ShapeModelViewer _viewerTemplate;
        [SerializeField] private Transform _content;
        [SerializeField] private Grid _grid;
        [SerializeField] private Tilemap _tilemap;
        //[SerializeField] private TileBase _tileBase;
        [SerializeField] private GameObject _cube;
        [SerializeField] private Tile _salverModel;

        private Queue<GameObject> _shapeModels;
        private TilePositionsLibrary positionsLibrary = new TilePositionsLibrary();
        private int _capacity;
        private int _currentQuantity = 0;

        public Queue<GameObject> Shapes => _shapeModels;

        private void Awake()
        {
            _capacity = positionsLibrary.Positions.Length;
            _shapeModels = new Queue<GameObject>(_capacity);
        }

        public void Add(ShapeAsset asset)
        {
            if (_currentQuantity >= _capacity)
                _currentQuantity = 0;

            _viewerTemplate.Init(asset);
            //Tile tile = new Tile();
            //tile.gameObject = _viewerTemplate.Model;
            _tilemap.SetTile(positionsLibrary.Positions[_currentQuantity], _viewerTemplate.TIle);
            

            _currentQuantity++;
        }

        private void DeleteFirst()
        {
            var a = _shapeModels.Peek();
            Destroy(a.gameObject);
            _shapeModels.Dequeue();
        }

        private bool IsFull()
        {
            return _shapeModels.Count >= _capacity;
        }

        public void TransferTo(Transform target)
        {
            transform.SetParent(transform);
        }
    }
}
