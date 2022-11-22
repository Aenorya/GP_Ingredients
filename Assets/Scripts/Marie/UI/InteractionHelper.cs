using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractionHelper : MonoBehaviour
{
    public GameObject interactionCue;
    public string interactionText, pickupText, failedText;
    public void Show(InteractionType interaction = InteractionType.None)
    {
        if (interaction != InteractionType.None)
        {
            interactionCue.SetActive(true);
            if (interaction == InteractionType.Pickup)
            {
                interactionCue.GetComponentInChildren<TextMeshProUGUI>().text = pickupText;
            }
            else if (interaction == InteractionType.FailedAction)
            {
                interactionCue.GetComponentInChildren<TextMeshProUGUI>().text = failedText;
            }else{
                interactionCue.GetComponentInChildren<TextMeshProUGUI>().text = interactionText;
            }
        }
        else
        {
            interactionCue.SetActive(false);
        }
    }
}
