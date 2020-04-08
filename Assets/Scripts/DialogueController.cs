using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogueController : MonoBehaviour
{
    [Tooltip("Select or drag the Dialog.asset for this level here")]
    public Dialogue LoadedDialogue;
    public TextMeshProUGUI textDisplay;
    public float typingSpeed;

    private int index = 0;

    void Start()
    {
        StartCoroutine(Type());
    }
    IEnumerator Type()
    {
        foreach (char letter in LoadedDialogue.DialogueItems[index].DialogueText)
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {

        if (index < LoadedDialogue.DialogueItems.Count - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
        }
    }


}
