using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Business.ColorButton
{
    public class ColorButtonView : MonoBehaviour
    {
        [SerializeField] private WinPopup winPopup;
        
        public Button _button;
        
        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnColorButtonClicked);
            winPopup.AnimationFinished += OnAnimationFinished;
        }

        private void OnAnimationFinished()
        {
            winPopup.Hide();
        }

        private void OnColorButtonClicked()
        {
            winPopup.Show();
        }

        private void OnDisable()
        {
            winPopup.AnimationFinished -= OnAnimationFinished;
        }
    }
}
