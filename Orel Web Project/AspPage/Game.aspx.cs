// Game.aspx.cs (code-behind)
using LielProject;
using LielProject.AppCode;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orel_Web_Project.AspPage
{
    public partial class Game : System.Web.UI.Page
    {
        Player Player;
        Player Dealer;
        Deck Deck;
        bool IsPlayerTurn;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Player = new Player { Chips = 1000, Bet = 100 }; // Hardcoded for now
                ViewState["Player"] = Player;
                InitGame();
            }
            else
            {
                Player = (Player)ViewState["Player"];
                Dealer = (Player)ViewState["Dealer"];
                Deck = (Deck)ViewState["Deck"];
                IsPlayerTurn = (bool)ViewState["IsPlayerTurn"];
            }
        }

        private void InitGame()
        {
            Deck = new Deck(new Random().Next(1, 9));
            Deck.Shuffle();
            Dealer = new Player();
            IsPlayerTurn = true;

            Player.Hand.Clear();
            Dealer.Hand.Clear();

            Player.Chips -= Player.Bet;

            Player.Deal(Deck);
            Dealer.Deal(Deck);
            Player.Deal(Deck);
            Dealer.Deal(Deck, hidden: true);

            ViewState["Player"] = Player;
            ViewState["Dealer"] = Dealer;
            ViewState["Deck"] = Deck;
            ViewState["IsPlayerTurn"] = IsPlayerTurn;

            RefreshScreen();

            if (Player.HandValue() == 21)
            {
                IsPlayerTurn = false;
                ViewState["IsPlayerTurn"] = false;
                EndTurn();
            }
        }

        private void RefreshScreen()
        {
            pnlPlayerCards.Controls.Clear();
            pnlDealerCards.Controls.Clear();

            foreach (var card in Dealer.Hand)
                pnlDealerCards.Controls.Add(CreateCardImage(card.Name, card.Hidden));

            foreach (var card in Player.Hand)
                pnlPlayerCards.Controls.Add(CreateCardImage(card.Name));

            lblPlayerValue.Text = $"Player: {Player.HandValue()}";
            lblDealerValue.Text = $"Dealer: {(Dealer.Hand[1].Hidden ? "?" : Dealer.HandValue().ToString())}";
            lblChips.Text = Player.Chips.ToString();
            lblBet.Text = Player.Bet.ToString();

            btnDouble.Visible = Player.Hand.Count <= 2;
            btnPlayAgain.Visible = false;
        }

        private void EndTurn()
        {
            Dealer.Hand[1].Hidden = false;
            RefreshScreen();

            while (Dealer.HandValue() < 17)
            {
                Dealer.Deal(Deck);
            }

            string message;
            if (Player.HandValue() == 21 && Dealer.HandValue() == 21)
            {
                message = "Push";
                Player.Chips += Player.Bet;
            }
            else if (Player.HandValue() == 21 && Player.Hand.Count == 2)
            {
                message = "Blackjack! You win!";
                Player.Chips += Player.Bet * 2.5;
            }
            else if (Dealer.HandValue() == 21 && Dealer.Hand.Count == 2)
            {
                message = "Dealer has blackjack! You lose.";
            }
            else if (Player.HandValue() > 21)
            {
                message = "You busted!";
            }
            else if (Dealer.HandValue() > 21)
            {
                message = "Dealer busted! You win!";
                Player.Chips += Player.Bet * 2;
            }
            else if (Player.HandValue() > Dealer.HandValue())
            {
                message = "You win!";
                Player.Chips += Player.Bet * 2;
            }
            else if (Player.HandValue() == Dealer.HandValue())
            {
                message = "Push";
                Player.Chips += Player.Bet;
            }
            else
            {
                message = "Dealer wins!";
            }

            lblDealerValue.Text = $"Dealer: {Dealer.HandValue()}";
            lblChips.Text = Player.Chips.ToString();
            btnPlayAgain.Visible = true;

            ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{message}');", true);
        }

        private Control CreateCardImage(string name, bool hidden = false)
        {
            Image img = new Image();
            img.ImageUrl = $"../cards/{(hidden ? "back" : name)}.png";
            img.Width = 80;
            img.Height = 120;
            img.Style["margin"] = "5px";
            return img;
        }

        protected void BtnHit_Click(object sender, EventArgs e)
        {
            if (!IsPlayerTurn) return;

            Player.Deal(Deck);
            RefreshScreen();

            if (Player.HandValue() >= 21)
            {
                IsPlayerTurn = false;
                ViewState["IsPlayerTurn"] = false;
                EndTurn();
            }

            ViewState["Player"] = Player;
            ViewState["Deck"] = Deck;
        }

        protected void BtnStand_Click(object sender, EventArgs e)
        {
            if (!IsPlayerTurn) return;

            IsPlayerTurn = false;
            ViewState["IsPlayerTurn"] = false;
            EndTurn();
        }

        protected void BtnDouble_Click(object sender, EventArgs e)
        {
            if (!IsPlayerTurn) return;

            Player.Chips -= Player.Bet;
            Player.Bet *= 2;
            Player.Deal(Deck);
            RefreshScreen();

            IsPlayerTurn = false;
            ViewState["IsPlayerTurn"] = false;
            EndTurn();
        }

        protected void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            InitGame();
        }
    }
}
