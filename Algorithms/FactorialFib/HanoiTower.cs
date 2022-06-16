using System;
using System.Collections.Generic;

namespace Arrays.FactorialFib
{
    public class HanoiTower
    {
        public int DiscsCount { get; private set; } 
        
        public int MovesCount { get; private set; } 
        
        public Stack<int> From { get; private set; } 
        
        public Stack<int> To { get; private set; } 
        
        public Stack<int> Temp { get; private set; }
        
        public event EventHandler<EventArgs> MoveCompleted;
        
        public HanoiTower(int discs) 
        { 
            DiscsCount = discs; 
            From = new Stack<int>(); 
            To = new Stack<int>(); 
            Temp = new Stack<int>(); 
            
            for (var i = 1; i <= discs; i++) 
            { 
                var size = discs - i + 1; 
                From.Push(size); 
            } 
        } 
        
        public void Start() 
        { 
            Move(DiscsCount, From, To, Temp); 
        }

        private void Move(int discs, Stack<int> from, Stack<int> to, Stack<int> temp) 
        { 
            if (discs > 0) 
            { 
                Move(discs - 1, from, temp, to); 
 
                to.Push(from.Pop()); 
                MovesCount++; 
                MoveCompleted?.Invoke(this, EventArgs.Empty); 
 
                Move(discs - 1, temp, to, from); 
            } 
        } 
    }
}