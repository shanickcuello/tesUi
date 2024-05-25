using System;
using UnityEngine;
using UnityEngine.UI;

namespace Business.ColorButton
{
    public class ColorButtonView : MonoBehaviour
    {
        public Button _button;
        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnColorButtonClicked);
        }

        private void OnColorButtonClicked()
        {
            Debug.Log("El boton fue clickealo");
        }
    }
}
