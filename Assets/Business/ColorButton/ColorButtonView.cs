        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnColorButtonClicked);
        }
