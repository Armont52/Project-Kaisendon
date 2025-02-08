using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    [SerializeField] private GameObject OptionMenuPanel;
    
    public void OpenOption(){
        OptionMenuPanel.SetActive(true);
    }
    public void ExitOption(){
        OptionMenuPanel.SetActive(false);
    }
}
