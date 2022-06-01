using System;
using UnityEngine;

namespace Maze
{
    [RequireComponent(typeof(Renderer)), ExecuteInEditMode]
    public sealed class EditorParams : MonoBehaviour
    {
        [HideInInspector] public float Public;
        public Vector3Serializable SerializableGameObject;
        private const int _min = 0;
        private const int _max = 100;
        [Header("Variables")]
        [ContextMenuItem("Randomize Number", nameof(Randomize))]
        [SerializeField] private float _private = 7;
        [Range(_min, _max)]
        public int Second;
        [Space(60)]
        [SerializeField, Multiline(5)] private string _multiline;
        [Space(60)]
        [SerializeField, TextArea(5, 5), Tooltip("Tooltip text")]
        private string
        _textArea;
        private void Update()
        {
            GetComponent<Renderer>().sharedMaterial.color = UnityEngine.Random.ColorHSV();
        }
        private void Randomize()
        {
            _private = UnityEngine.Random.Range(_min, _max);
        }
        [Obsolete("Устарело. Используй что-то другое")]
        private void Obsolete()
        {
        }
    }
}
