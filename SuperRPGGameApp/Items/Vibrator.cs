﻿namespace SuperRPGGameApp.Items
{
    class Vibrator : Item
    {
        private const int VibratorHealth = 0;
        private const int VibratorDamage = 50;
        
        public Vibrator(Position position)
            : base(VibratorHealth, VibratorDamage, position)
        {
        }
    }
}