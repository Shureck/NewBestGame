using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // ����� ��� �������� ����� �� � �����
    public void LoadScene(string Scane)
    {
        SceneManager.LoadScene(Scane);
    }

    // ����� ��� ������ �� ����
    public void QuitGame()
    {
        // ���� ��� ����� �������� ������ ��� ������ �� ��������� (�� � ���������)
        // � ��������� ���� ���������� �� ����� �������
        Application.Quit();
    }
}
