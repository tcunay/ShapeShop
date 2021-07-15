using UnityEngine;
using UnityEngine.Tilemaps;
using Game.Shapes;

namespace Game.Viewers
{
    public class ShapeTileViewer : ShapeViewer
    {
        private Tile _tile;
        private GameObject _model;

        protected override void SetColorForVisibleObject(Color color)
        {
            _model.GetComponentInChildren<Renderer>().material.color = color;
        }

        protected override void InitVisibleObject(ShapeAsset shapeAsset)
        {
            _model = Instantiate(shapeAsset.ModelContainer);

            SetColorForVisibleObject(shapeAsset.Color);
            InitTile(_model);

            Destroy(_model);
        }

        public void Show(Vector3Int position, Tilemap tilemap)
        {
            tilemap.SetTile(position, _tile);
        }

        private void InitTile(GameObject model)
        {
            _tile = ScriptableObject.CreateInstance<Tile>();
            SetModel(model);
        }

        private void SetModel(GameObject model)
        {
            _tile.gameObject = model;
        }
    }
}
