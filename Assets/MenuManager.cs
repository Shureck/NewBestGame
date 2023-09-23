using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Метод для загрузки сцены по её имени
    public void LoadScene(string Scane)
    {
        SceneManager.LoadScene(Scane);
    }

    // Метод для выхода из игры
    public void QuitGame()
    {
        // Этот код будет работать только при сборке на платформу (не в редакторе)
        // В редакторе игры приложение не будет закрыто
        Application.Quit();
    }
}
