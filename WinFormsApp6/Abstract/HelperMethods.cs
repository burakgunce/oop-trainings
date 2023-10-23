using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6.Abstract
{
    public abstract class HelperMethods
    {
        public virtual void PlaySimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\PC\Downloads\default.wav");
            simpleSound.Play();
        }

    }
}
