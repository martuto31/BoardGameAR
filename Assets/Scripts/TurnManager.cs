using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance;

    public TMP_Text turnText;
    public TMP_Text feedbackText;

    public bool isPlayerTurn = true;
    public bool playerIsProtected = false;
    private string npcCard = "";

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    void Start()
    {
        npcCard = GetRandomCard();
        UpdateTurnUI();
    }

    public bool CanPlayCard()
    {
        return isPlayerTurn;
    }

    public void EndPlayerTurn()
    {
        isPlayerTurn = false;
        UpdateTurnUI();
        Invoke(nameof(NpcTurn), 2f);
    }

    void NpcTurn()
    {
        string npcAction = GetRandomNpcAction();

        if (playerIsProtected)
        {
            feedbackText.text = $"NPC played {npcAction}, but you were protected!";
            playerIsProtected = false;
        }
        else
        {
            feedbackText.text = $"NPC played {npcAction}.";

            if (npcAction == "Guard")
            {
                string guess = GetRandomCard();
                if (guess == "Priest")
                    feedbackText.text += " NPC guessed correctly! You are eliminated.";
                else
                    feedbackText.text += " NPC guessed wrong.";
            }
        }

        isPlayerTurn = true;
        UpdateTurnUI();
    }

    void UpdateTurnUI()
    {
        turnText.text = isPlayerTurn ? "Your Turn" : "NPC's Turn...";
    }

    string GetRandomCard()
    {
        string[] cards = { "Guard", "Priest", "Maid" };
        return cards[Random.Range(0, cards.Length)];
    }

    string GetRandomNpcAction()
    {
        string[] cards = { "Guard", "Priest", "Maid" };
        return cards[Random.Range(0, cards.Length)];
    }

    public string GetNpcCard()
    {
        return npcCard;
    }
}
