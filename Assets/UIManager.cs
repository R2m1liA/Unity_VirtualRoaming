using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject PauseMenu;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(!PauseMenu.activeSelf);

            if (PauseMenu.activeSelf)
            {
                // 显示指针
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                
            }
            else
            {
                // 隐藏指针
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
