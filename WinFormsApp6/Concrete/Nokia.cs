﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp6.Abstract;

namespace WinFormsApp6.Concrete
{
    public class Nokia : HelperMethods
    {
        public override void PlaySimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\PC\Downloads\nokia.wav");
            simpleSound.Play(); ;
        }
    }
}