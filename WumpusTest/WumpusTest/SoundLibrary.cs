using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WumpusTest
{
    class SoundLibrary
    {
        private string soundsPath = @"C:\Users\Brogan\Source\Repos\WumpusTest\WumpusTest\WumpusTest\Sounds\";
        private SoundPlayer soundPlayer;
        public void PlaySound(string name)
        {
            string path = soundsPath + name;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = path;
            soundPlayer.LoadCompleted += SoundPlayer_LoadCompleted;
            soundPlayer.Load();
        }

        private void SoundPlayer_LoadCompleted(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }
    }
}
