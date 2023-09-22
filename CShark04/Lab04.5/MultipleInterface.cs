using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._5
{
    internal interface MultipleInterface
    {
        public interface IDriveable 
        {
            void Start();
            void Stop();
            bool Started { get; }
        }

        public interface ISteerable
        {
            void TurnLeft();
            void TurnRight();
        }

        public interface IMovable : IDriveable, ISteerable
        {
            void Accelerate();
            void Brake();
        }


    }
}
