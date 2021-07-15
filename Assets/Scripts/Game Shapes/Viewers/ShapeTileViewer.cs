using Game.Shapes;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Game.Viewers
{
    public class ShapeTileViewer : ShapeViewer
    {
        private Tile _tile;
        private ModelContainer _modelContainer;

        protected override void SetColorForVisibleObject(Color color)
        {
            _modelContainer.Renderer.material.color = color;
        }

        protected override void InitVisibleObject(ShapeAsset shapeAsset)
        {
            _modelContainer = Instantiate(shapeAsset.ModelContainer);

            SetColorForVisibleObject(shapeAsset.Color);
            InitTile(_modelContainer.gameObject);

            Destroy(_modelContainer.gameObject);
        }

        public void Show(Vector3Int position, Tilemap tilemap)
        {
            tilemap.SetTile(position, _tile);
        }

        private void InitTile(GameObject model)
        {
            _tile = new Tile();
            SetModel(model);
        }

        private void SetModel(GameObject model)
        {
            _tile.gameObject = model;
        }
    }
}
