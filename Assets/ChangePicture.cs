using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePicture : MonoBehaviour
{
    public Image imageComponent; // Ссылка на компонент Image, который вы хотите изменить
    public Sprite newImage; // Новая картинка (спрайт), которую вы хотите установить

    // Вызывается при нажатии на кнопку или другое событие
    public void ChangeImageSprite()
    {
        if (imageComponent != null && newImage != null)
        {
            // Установить новый спрайт для компонента Image
            imageComponent.sprite = newImage;
        }
        else
        {
            Debug.LogWarning("Не установлен компонент Image или новая картинка не назначена.");
        }
    }
}