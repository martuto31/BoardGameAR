using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PriestCard : MonoBehaviour
{
    public TMP_Text feedbackText;
    private string npcCard;

    void Start()
    {
        npcCard = GetRandomCard();
    }

    void OnMouseDown()
    {
        if (!TurnManager.Instance.CanPlayCard()) return;

        string npcCard = TurnManager.Instance.GetNpcCard();
        feedbackText.text = "NPC is holding: " + npcCard;
        gameObject.SetActive(false);
        TurnManager.Instance.EndPlayerTurn();
    }

    string GetRandomCard()
    {
        string[] cards = { "Guard", "Maid" };
        return cards[Random.Range(0, cards.Length)];
    }
}
