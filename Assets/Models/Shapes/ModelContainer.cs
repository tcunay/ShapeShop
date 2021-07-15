using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class ModelContainer : MonoBehaviour
    {
        [SerializeField] private GameObject _model;
        [SerializeField] private Renderer _renderer;


        public GameObject Model => _model;
        public Renderer Renderer => _renderer;
    }
}