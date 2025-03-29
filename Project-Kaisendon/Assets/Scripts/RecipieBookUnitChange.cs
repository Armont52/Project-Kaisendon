using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class RecipieBookUnitChange : MonoBehaviour
{
    [Header("Unit Button Settings")]
    public GameObject[] unitButtons; // Prefab UnitButton
    public Sprite unitBackgroundSprite;
    public Sprite frameSprite;
    public Sprite[] unitSprites;

    [Header("Ingredient Button Settings")]
    public GameObject IngredientButton;

    [Header("Ingredient Select Settings")]
    public GameObject[] ingredientSelectButtons; // Prefab UnitButton
    //public Sprite ingredientBackgroundSprite;
    public Sprite[] ingredientSprites;
    
    void Start()
    {
        // unitButton default setting
        if (unitButtons.Length != 11 || unitSprites.Length != 11)
        {
            Debug.LogWarning("Make sure you have 11 buttons and 11 unit images assigned!");
            return;
        }

        for (int i = 0; i < unitButtons.Length; i++)
        {
            Transform buttonTransform = unitButtons[i].transform;

            // Find child image components
            Image background = buttonTransform.Find("Background").GetComponent<Image>();
            Image frame = buttonTransform.Find("Frame").GetComponent<Image>();
            Image unitImage = buttonTransform.Find("UnitImage").GetComponent<Image>();

            // Assign the same background and frame to all buttons
            if (background != null) background.sprite = unitBackgroundSprite;
            if (frame != null) frame.sprite = frameSprite;

            // Assign unique unit images
            if (unitImage != null && i < unitSprites.Length)
            {
                unitImage.sprite = unitSprites[i];
            }
        }

        // ingredientButton default setting
        if (ingredientSelectButtons.Length != 12 || ingredientSprites.Length != 12)
        {
            Debug.LogWarning("Make sure you have 12 buttons and 12 ingredient images assigned!");
            return;
        }

        for (int i = 0; i < ingredientSelectButtons.Length; i++)
        {
            Transform buttonTransform = ingredientSelectButtons[i].transform;

            // Find child image components
            Image ingredientImage = buttonTransform.Find("IngredientImage").GetComponent<Image>();

            // Assign unique unit images
            if (ingredientImage != null && i < ingredientSprites.Length)
            {
                ingredientImage.sprite = ingredientSprites[i];
            }
        }
    }

    void Update()
    {
        
    }

    void changeIngredient(){
        
    }
}
