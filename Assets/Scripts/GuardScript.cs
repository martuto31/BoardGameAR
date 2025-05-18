using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuardCard : MonoBehaviour
{
    public Button guessPriestButton;
    public Button guessMaidButton;
    public TMP_Text feedbackText;

    private string npcCard;
    private bool hasGuessed = false;

    void Start()
    {
        npcCard = GetRandomCard();

        guessPriestButton.gameObject.SetActive(false);
        guessMaidButton.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        if (hasGuessed || !TurnManager.Instance.CanPlayCard()) return;

        feedbackText.text = "Guess the NPC's card:";
        guessPriestButton.gameObject.SetActive(true);
        guessMaidButton.gameObject.SetActive(true);
    }

    public void GuessCard(string guessedCard)
    {
        if (hasGuessed) return;

        hasGuessed = true;

        guessPriestButton.gameObject.SetActive(false);
        guessMaidButton.gameObject.SetActive(false);

        if (TurnManager.Instance.playerIsProtected)
        {
            feedbackText.text = "NPC is protected! Nothing happens.";
            TurnManager.Instance.playerIsProtected = false;
        }
        else if (npcCard == guessedCard)
        {
            feedbackText.text = "Correct! NPC is eliminated.";
        }
        else
        {
            feedbackText.text = "Wrong. NPC survives.";
        }

        gameObject.SetActive(false);
        TurnManager.Instance.EndPlayerTurn();
    }

    string GetRandomCard()
    {
        string[] cards = { "Priest", "Maid" };
        return cards[Random.Range(0, cards.Length)];
    }
}
