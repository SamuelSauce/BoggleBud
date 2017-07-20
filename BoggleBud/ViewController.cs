using System;

using UIKit;


namespace BoggleBud
{
    public partial class ViewController : UIViewController
    {
		private BoggleGame Game;
        private string currWord = "";
		private int wordLength;


        partial void D4_TouchUpInside(UIButton sender)
        {
            this.currWord += Game.Board[15];
            wordLength++;
            Word.Text = currWord;
        }

        partial void D3_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[14];
			wordLength++;
            Word.Text = currWord;
        }

        partial void D2_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[13];
			wordLength++;
            Word.Text = currWord;
        }

        partial void D1_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[12];
			wordLength++;
            Word.Text = currWord;
        }

        partial void C4_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[11];
			wordLength++;
            Word.Text = currWord;
        }

        partial void C3_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[10];
			wordLength++;
            Word.Text = currWord;
        }

        partial void C2_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[9];
			wordLength++;
            Word.Text = currWord;
        }

        partial void C1_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[8];
			wordLength++;
            Word.Text = currWord;
        }

        partial void B4_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[7];
			wordLength++;
            Word.Text = currWord;
        }

        partial void B3_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[6];
			wordLength++;
            Word.Text = currWord;
        }

        partial void B2_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[5];
			wordLength++;
            Word.Text = currWord;
        }

        partial void B1_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[4];
			wordLength++;
            Word.Text = currWord;
        }

        partial void A4_TouchUpInside(UIButton sender)
        {
            this.currWord += Game.Board[3];
			wordLength++;
            Word.Text = currWord;
        }

        partial void A3_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[2];
			wordLength++;
            Word.Text = currWord;
        }

        partial void A2_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[1];
			wordLength++;
            Word.Text = currWord;
        }

        partial void A1_TouchUpInside(UIButton sender)
        {
			this.currWord += Game.Board[0];
			wordLength++;
            Word.Text = currWord;
        }


        partial void PlayWord_TouchUpInside(UIButton sender)
        {
            Score.Text = "Score: " + Game.PlayWord(currWord);
            wordLength = 0;
            currWord = "";
            Word.Text = currWord;
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void PlayGame_TouchUpInside(UIButton sender)
        {
            Game = new BoggleGame();
            PlayGame.Enabled = false;
            SetBoard();
            return;
        }

        private void SetBoard()
        {
            a1.SetTitle(Game.Board[0], UIControlState.Normal);
            a2.SetTitle(Game.Board[1], UIControlState.Normal);
            a3.SetTitle(Game.Board[2], UIControlState.Normal);
            a4.SetTitle(Game.Board[3], UIControlState.Normal);
            b1.SetTitle(Game.Board[4], UIControlState.Normal);
            b2.SetTitle(Game.Board[5], UIControlState.Normal);
            b3.SetTitle(Game.Board[6], UIControlState.Normal);
            b4.SetTitle(Game.Board[7], UIControlState.Normal);
            c1.SetTitle(Game.Board[8], UIControlState.Normal);
            c2.SetTitle(Game.Board[9], UIControlState.Normal);
            c3.SetTitle(Game.Board[10], UIControlState.Normal);
            c4.SetTitle(Game.Board[11], UIControlState.Normal);
            d1.SetTitle(Game.Board[12], UIControlState.Normal);
            d2.SetTitle(Game.Board[13], UIControlState.Normal);
            d3.SetTitle(Game.Board[14], UIControlState.Normal);
            d4.SetTitle(Game.Board[15], UIControlState.Normal);
            Score.Text = "Score: " + Game.Player1Score;

        }
    }
}
