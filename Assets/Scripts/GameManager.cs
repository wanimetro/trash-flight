using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager instance = null;

   [SerializeField]
   private TextMeshProUGUI text;
   private int coin = 0;

   void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    public void IncreaseCoin() {
        coin += 1;
        text.SetText(coin.ToString());

        if (coin % 10 == 0) {
            Player player = FindFirstObjectByType<Player>();
            if (player != null) {
                player.Upgrade();
            }
        }
    }
}
