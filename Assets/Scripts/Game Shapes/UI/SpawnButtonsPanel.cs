using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Game.AssetsLibrary;
using System;
using Game.Shapes;

namespace Game.UI
{
    public class SpawnButtonsPanel : MonoBehaviour
    {
        [SerializeField] private ShapeAssetsLibrary _assetsLibrary;
        [SerializeField] private Button _confirmationButtonTemplate;
        [SerializeField] private SpawnButton _template;

        private List<SpawnButton> _spawnButtons;
        private Button _confirmationButton;

        public event Action<ShapeAsset> SpawnNeeded;

        private void Awake()
        {
            Init();
        }

        private void OnDisable()
        {
            UnsubscribeFromSpawbButtons();
        }

        private void Init()
        {
            InitSpawnButtons();
            InitConfirmationButton();
        }

        private void InitSpawnButtons()
        {
            _spawnButtons = new List<SpawnButton>(_assetsLibrary.Assets.Count);
            for (int i = 0; i < _assetsLibrary.Assets.Count; i++)
            {
                _spawnButtons.Add(Instantiate(_template, transform));
                _spawnButtons[i].Viewer.Init(_assetsLibrary.Assets[i]);
                _spawnButtons[i].OnClick += OnSpawnButtonClicked;
            }
        }

        private void InitConfirmationButton()
        {
            _confirmationButton = Instantiate(_confirmationButtonTemplate, transform);
        }

        private void OnSpawnButtonClicked(ShapeAsset shapeAsset)
        {
            SpawnNeeded?.Invoke(shapeAsset);
        }

        private void UnsubscribeFromSpawbButtons()
        {
            foreach (var item in _spawnButtons)
            {
                item.OnClick -= OnSpawnButtonClicked;
            }
        }
    }
}