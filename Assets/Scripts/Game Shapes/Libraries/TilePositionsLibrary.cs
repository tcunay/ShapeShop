using UnityEngine;

namespace Game.Libraries
{
    public class TilePositionsLibrary
    {
        private Vector3Int[] _positions = { new Vector3Int(2, 1, 0), new Vector3Int(4, 1, 0), new Vector3Int(3, 2, 0) };

        public Vector3Int[] Positions => _positions;
    }
}
