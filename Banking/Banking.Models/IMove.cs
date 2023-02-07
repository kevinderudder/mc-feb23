using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
    public class Logic {

        public IMove MovableObject { get; set; }

        public void Play() {

            this.MovableObject = new Elephant();
            this.MovableObject.Move(2,7);
            
        }

    }

    public interface IMove
    {
        void Move(int x, int y);
        void Stop();
    }

    public interface IEat
    {
        void Eat();
    }


    public class Snake : IMove
    {
        public void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Elephant : IMove
    {
        public void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Walk() { 
        
        }
    }
    public class Hippopotamus : IMove
    {
        public void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
  

 
}
