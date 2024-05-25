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
