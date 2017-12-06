using System;
using FinalProject.Properties.Menu;
namespace FinalProject
{
    
    public class StationOverflowException : Exception
    {
        
        public StationOverflowException()
        {
            Menu.speach("The sorting center overflowed");
            return;
        }
    }
}
