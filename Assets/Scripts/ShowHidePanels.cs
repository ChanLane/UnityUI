using UnityEngine;

public class ShowHidePanels : MonoBehaviour
{
    [SerializeField] private CanvasGroup inventoryPanel;
    [SerializeField] private bool inventoryUp = false;

    [SerializeField] public CanvasGroup pausePanel;
    [SerializeField] public bool pauseUp = false;
        
    // Start is called before the first frame update
    void Start()
    {
        inventoryPanel.alpha = 0;
        inventoryPanel.interactable = false;
        inventoryPanel.blocksRaycasts = false;

        pausePanel.alpha = 0;
        pausePanel.interactable = false;
        pausePanel.blocksRaycasts = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventoryUp == false)
            {
                inventoryUp = true;
                inventoryPanel.alpha = 1;
                inventoryPanel.interactable = true;
                inventoryPanel.blocksRaycasts = true;
            }
            else
            {
                inventoryUp = false;
                inventoryPanel.alpha = 0;
                inventoryPanel.interactable = false;
                inventoryPanel.blocksRaycasts = false;
            }
        }

        if (Input.GetButtonDown("pause"))
        {
            if (pauseUp == false)
            {
                pauseUp = true;
                pausePanel.alpha = 1;
                pausePanel.interactable = false;
                pausePanel.blocksRaycasts = false;
            }
        }
    }
}