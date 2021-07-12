using System.Collections.Generic;
using UnityEngine;
using Game.Viewers;
using Game.Shapes;
using UnityEngine.Tilemaps;

namespace Game.Salvers
{
    public class Salver : MonoBehaviour
    {
        [SerializeField] private ShapeModelViewer _viewerTemplate;
        [SerializeField] private Transform _content;
        [SerializeField] private Grid _grid;
        [SerializeField] private Tilemap _tilemap;
        //[SerializeField] private TileBase _tileBase;
        [SerializeField] private GameObject _cube;
        [SerializeField] private Tile _salverModel;

        private Queue<ShapeModelViewer> _shapeModels;
        private int _capacity = 3;
        private TileData _tileData;

        public Queue<ShapeModelViewer> Shapes => _shapeModels;

        private void Awake()
        {
            _shapeModels = new Queue<ShapeModelViewer>(_capacity);
        }

        private void Start()
        {
            _tilemap.FloodFill(new Vector3Int(0, 0, 0), _salverModel);
        }

        public void Add(ShapeAsset asset)
        {
            if (IsFull())
            {
                DeleteFirst();
            }
            _tilemap.ClearAllTiles();
            _tilemap.FloodFill(new Vector3Int(1, 0, 0), asset);
            //ShapeModelViewer shapeViewer = Instantiate(_viewerTemplate, _content);
            //shapeViewer.Init(asset);
            //_shapeModels.Enqueue(shapeViewer);
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
