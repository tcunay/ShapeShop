using UnityEngine;
using UnityEngine.Tilemaps;
using Game.Viewers;
using Game.Shapes;
using Game.Libraries;

namespace Game.Salvers
{
    [RequireComponent(typeof(ShapeTileViewer))]
    public class Salver : MonoBehaviour
    {
        [SerializeField] private Tilemap _tilemap;

        private ShapeTileViewer _viewer;
        private TilePositionsLibrary positionsLibrary = new TilePositionsLibrary();
        private int _capacity;
        private int _currentQuantity = 0;

        private void Awake()
        {
            _viewer = GetComponent<ShapeTileViewer>();
            _capacity = positionsLibrary.Positions.Length;
        }

        public void Add(ShapeAsset asset)
        {
            if (IsFull())
                _currentQuantity = 0;

            _viewer.Init(asset);
            _viewer.Show(positionsLibrary.Positions[_currentQuantity], _tilemap);

            _currentQuantity++;
        }

        private bool IsFull()
        {
            return _currentQuantity >= _capacity;
        }

        public void TransferTo(Transform target)
        {
            transform.SetParent(transform);
        }
    }
}
