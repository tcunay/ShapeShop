using System;
using UnityEngine;
using UnityEngine.UI;
using Game.Shapes;
using Game.Viewers;

namespace Game.UI
{
    [RequireComponent(typeof(Button))]
    public class SpawnButton : MonoBehaviour
    {
        [SerializeField] private ShapeIconViewer _viewer;

        private Button _button;

        public ShapeViewer Viewer => _viewer;
        public Action<ShapeAsset> OnClick;// => _button.onClick;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClicked);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            OnClick?.Invoke(_viewer.Asset);
        }
    }
}
