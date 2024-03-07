
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private NPCDialogue dialogueShow;
    [SerializeField] private GameObject interactionBox;

    public NPCDialogue DialogueToShow => dialogueShow;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DialogueManager.Instance.NPCSelected = this;
            interactionBox.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DialogueManager.Instance.NPCSelected = null;
            DialogueManager.Instance.CloseDialogueOPanel();
            interactionBox.SetActive(false);
        }

    }
}
