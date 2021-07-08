using System.Collections.Generic;
using UnityEngine;
using Game.Viewers;

namespace Game.Salvers
{
    public class ShapesSalver : MonoBehaviour
    {
        private Queue<ShapeModelViewer> _shapeModels;
        private int _capacity;

        public Queue<ShapeModelViewer> Shapes => _shapeModels;

        public void Init(int capacity)
        {
            _capacity = capacity;
            _shapeModels = new Queue<ShapeModelViewer>(capacity);
        }

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
            return false;
            //return _shapeModels.Count >= _capacity;
        }
    }
}
