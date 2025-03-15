using UnityEngine;

public class IngredientOptionMenu : MonoBehaviour
{
    [SerializeField] private GameObject IngredientPanel;
    
    public void OpenOption(){
        IngredientPanel.SetActive(true);
    }
    public void ExitOption(){
        IngredientPanel.SetActive(false);
    }
}
