using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MaidCard : MonoBehaviour
{
    public TMP_Text feedbackText;
    public static bool playerIsProtected = false;

    void OnMouseDown()
    {
        if (!TurnManager.Instance.CanPlayCard()) return;

        TurnManager.Instance.playerIsProtected = true;
        feedbackText.text = "You are protected until NPC's next turn.";
        gameObject.SetActive(false);
        TurnManager.Instance.EndPlayerTurn();
    }

}
