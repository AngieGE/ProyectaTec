using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillModelImage : MonoBehaviour
{
    [SerializeField] private Image modalImage;
    Button modalButton;
    Image menuButtonImage;

    void Awake()
    {
        modalButton = this.GetComponent<Button>();
    }

    void Start()
    {
        modalButton.onClick.AddListener(SetImageModal);
        menuButtonImage = this.GetComponent<Image>();
    }

    void SetImageModal()
    {
        modalImage.sprite = menuButtonImage.sprite;
    }
}
