using Game.Shapes;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Game.Viewers
{
    public class ShapeModelViewer : ShapeViewer
    {
        private Tile _tile;

        public Tile TIle => _tile;

        protected override void InitColorForVisibleObject(Color color)
        {
            _tile.gameObject.GetComponent<Renderer>().material.color = color;
        }

        protected override void InitVisibleObject(ShapeAsset shapeAsset)
        {
            _tile = shapeAsset; //Instantiate(shapeAsset.Model);
            //InitColorForVisibleObject(shapeAsset.Color);
        }
    }
}
