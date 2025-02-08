using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private string currentSceneName;

    private void Start() {
        currentSceneName = SceneManager.GetActiveScene().name;
    }

    public void LoadStageSelect(){
        SceneManager.LoadScene("StageSelect");
    }

    public void LoadStage(){
        SceneManager.LoadScene("Stage");
    }

    public void LoadShop(){
        SceneManager.LoadScene("Shop");
    }

    public void LoadUnit(){
        SceneManager.LoadScene("Units");
    }
    
    public void LoadCurrentScene(){
        SceneManager.LoadScene(currentSceneName);
    }
}
