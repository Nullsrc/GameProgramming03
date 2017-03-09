using System;
using System.Windows.Forms;

namespace FPSTest
{
    public class Program : Engine
    {

        static SlideSprite spriteCan;


        protected override void OnKeyDown(KeyEventArgs e)
        {
            //base.OnKeyDown(e);
            //Console.WriteLine("asdffasdf");
            if (e.KeyCode == Keys.Left) { spriteCan.TargetX = spriteCan.X - 30; spriteCan.updateMove(); }
            if (e.KeyCode == Keys.Right) { spriteCan.TargetX = spriteCan.X + 30; spriteCan.updateMove(); }
            if (e.KeyCode == Keys.Up) { spriteCan.TargetY = spriteCan.Y - 30; spriteCan.updateMove(); }
            if (e.KeyCode == Keys.Down) { spriteCan.TargetY = spriteCan.Y + 30; spriteCan.updateMove(); }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            spriteCan = new SlideSprite(Properties.Resources.sprite, 100, 100);
            spriteCan.Velocity = 5;
            Program.canvas.Add(spriteCan);
            Application.Run(new Program());
        }
    }
}
