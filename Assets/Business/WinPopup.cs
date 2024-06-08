using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Business
{
    public class WinPopup : MonoBehaviour
    {
        public event Action AnimationFinished;

        private void Awake()
        {
            gameObject.SetActive(false);
        }

        public void Show()
        {
            gameObject.SetActive(true);
            StartCoroutine(ChangeColorCoroutine());
        }

        private IEnumerator ChangeColorCoroutine()
        {
            yield return new WaitForSeconds(3);
            GetComponent<Image>().color = Color.green;
            yield return new WaitForSeconds(3);
            AnimationFinished?.Invoke();
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        private void OnDestroy()
        {
            AnimationFinished = null;
        }
    }
}