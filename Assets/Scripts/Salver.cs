using System.Collections.Generic;
using UnityEngine;
using Game.Viewers;
using Game.Shapes;

namespace Game.Salvers
{
    public class Salver : MonoBehaviour
    {
        [SerializeField] private ShapeModelViewer _viewerTemplate;
        [SerializeField] private Transform _content;

        private Queue<ShapeModelViewer> _shapeModels;
        private int _capacity = 3;

        public Queue<ShapeModelViewer> Shapes => _shapeModels;

        private void Awake()
        {
            _shapeModels = new Queue<ShapeModelViewer>(_capacity);
        }

        public void Add(ShapeAsset asset)
        {
            if (IsFull())
            {
                DeleteFirst();
            }

            ShapeModelViewer shapeViewer = Instantiate(_viewerTemplate, _content);
            shapeViewer.Init(asset);
            _shapeModels.Enqueue(shapeViewer);
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
