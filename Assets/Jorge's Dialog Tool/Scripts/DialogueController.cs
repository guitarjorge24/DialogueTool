using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DialogueController : MonoBehaviour
{
    [Tooltip("Select or drag the Dialog.asset for this level here")]
    public Dialogue LoadedDialogue;
    public TextMeshProUGUI dialogueTextDisplay;
    public TextMeshProUGUI characterNameText;
    public float typingSpeed;
    public Image characterImage;

    private int index = 0;

    void Start()
    {
        dialogueTextDisplay.text = "";
        StartCoroutine(Type());
    }
    IEnumerator Type()
    {
        characterNameText.text = LoadedDialogue.CharactersList[LoadedDialogue.DialogueItems[index].CharacterID];
        characterImage.sprite = LoadedDialogue.DialogueItems[index].CharacterPic;

        foreach (char letter in LoadedDialogue.DialogueItems[index].DialogueText)
        {
            dialogueTextDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {

        if (index < LoadedDialogue.DialogueItems.Count - 1)
        {
            index++;
            dialogueTextDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            dialogueTextDisplay.text = "";
        }
    }


}
