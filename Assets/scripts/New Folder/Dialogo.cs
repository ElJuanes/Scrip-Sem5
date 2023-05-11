using System.Collections;
using UnityEngine;
using TMPro;
public class Dialogo : MonoBehaviour
{
   [SerializeField, TextArea(5,7)] private string[] dialogueLines;
   [SerializeField] private GameObject dialogopanel;
   [SerializeField] private TMP_Text textdialogo;
    private bool isPlayerInRange;
    private bool didDialogueStart; 
    private int lineIndex;
    private float typingTime = 0.1f;
  
    
    void Update()
    {
        if(isPlayerInRange)
        {
            if(!didDialogueStart)
            {
                StartDialogue();
            }
            else if(textdialogo.text==dialogueLines[lineIndex])
            {
                NextDialogueLine();
            }
            /*else
            {
                StopAllCoroutines();
                textdialogo.text = dialogueLines[lineIndex];
            }
            */
            
        }
    }

    private void StartDialogue()
    {
        didDialogueStart=true;
        dialogopanel.SetActive(true);
        lineIndex=0;
        Time.timeScale = 0f;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine()
    {
        textdialogo.text = string.Empty;

        foreach(char ch in dialogueLines[lineIndex])
        {
                textdialogo.text += ch; 
                yield return new WaitForSeconds(typingTime);
        }
        
    }


    private void NextDialogueLine()
{
    lineIndex++;
    if(lineIndex < dialogueLines.Length)
    {
        StartCoroutine(ShowLine());
    } 
    else 
    {
        dialogopanel.SetActive(false);
        Time.timeScale = 1f;
        StopAllCoroutines();
        didDialogueStart=false;
        isPlayerInRange=false;
    }
}


    private void OnTriggerEnter2D(Collider2D collision)
    {

       if(collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("No gracias");
        } 
     
    }



     private void OnTriggerExit2D(Collider2D collision)
    {

       if(collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("gracias");
        } 
     
    }

}
