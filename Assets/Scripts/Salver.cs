using System.Collections.Generic;
using UnityEngine;
using Game.Viewers;
using Game.Spawners;

namespace Game.Salvers
{
    public class Salver : MonoBehaviour
    {
        private Queue<ShapeModelViewer> _shapeModels;
        private IReportNeedSpawnable _reportNeedSpawnable;
        private int _capacity = 3;

        public Queue<ShapeModelViewer> Shapes => _shapeModels;

        private void Awake()
        {
            _shapeModels = new Queue<ShapeModelViewer>(_capacity);
        }

        //public void Init(int capacity)
        //{
        //    _capacity = capacity;
        //    _shapeModels = new Queue<ShapeModelViewer>(capacity);
        //}

        public void Add(ShapeModelViewer item)
        {
            if (IsFull())
            {
                DeleteFirst();
            }

            _shapeModels.Enqueue(item);
        }

        private void DeleteFirst()
        {
            _shapeModels.Dequeue();
        }

        private bool IsFull()
        {
           return _shapeModels.Count >= _capacity;
        }
    }
}
